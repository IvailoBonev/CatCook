using Azure.Identity;
using CatCook.Core.Contracts;
using CatCook.Core.Models.Recipe;
using CatCook.Infrastructure.Common;
using CatCook.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CatCook.Core.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRepository repo;

        public RecipeService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<ICollection<RecipeCategoryModel>> AllCategories()
        {
            return await repo.AllReadonly<Category>()
                .OrderBy(c => c.Name)
                .Select(c => new RecipeCategoryModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task<ICollection<RecipeDifficultyModel>> AllDifficulties()
        {
            return await repo.AllReadonly<Difficulty>()
                .OrderBy(c => c.Name)
                .Select(c => new RecipeDifficultyModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task<ICollection<RecipeHomeModel>> LastFourRecipes(string userId)
        {
            return await repo.AllReadonly<Recipe>()
                .Where(r => (r.IsPrivate == false || r.UserId == userId) && r.IsDeleted == false)
                .OrderByDescending(r => r.DateAdded)
                .Select (r => new RecipeHomeModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    DifficultyName = r.Difficulty.Name,
                    CategoryName = r.Category.Name,
                    ImageUrl = r.ImageUrl,
                    IsPrivate = r.IsPrivate,
                    Rating = r.Rating.Any() ? r.Rating.Average() : 0,
                    DateAdded = r.DateAdded.ToString("dd/MM"),
                    UserName = r.User.ProfileName
                })
                .Take(4)
                .ToListAsync();
        }

        public async Task<RecipeQueryModel> AllRecipes(string userId,
            string? category = null,
            string? difficulty = null,
            string? searchTerm = null,
            RecipeSorting sorting = RecipeSorting.Newest, 
            int currentPage = 1, int recipesPerPage = 1)
        {
            var result = new RecipeQueryModel();
            var recipes = repo.AllReadonly<Recipe>()
                .Where(r => (r.IsPrivate == false || r.UserId == userId) && r.IsDeleted == false);

            if (string.IsNullOrEmpty(category) == false)
            {
                recipes = recipes
                    .Where(h => h.Category.Name == category);
            }

            if (string.IsNullOrEmpty(difficulty) == false)
            {
                recipes = recipes
                    .Where(h => h.Difficulty.Name == difficulty);
            }

            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                searchTerm = $"%{searchTerm.ToLower()}%";

                recipes = recipes
                    .Where(r => EF.Functions.Like(r.Name.ToLower(), searchTerm) ||
                        EF.Functions.Like(r.Descipriton.ToLower(), searchTerm));
            }

            recipes = sorting switch
            {
                RecipeSorting.Newest => recipes
                    .OrderByDescending(r => r.DateAdded),
                RecipeSorting.Rating => recipes
                    .OrderByDescending(r => r.Rating.Average()),
                _ => recipes.OrderByDescending(r => r.Rating.Average())
                        .ThenByDescending(r => r.DateAdded)
            };

            result.Recipes = await recipes
                .Skip((currentPage - 1) * recipesPerPage)
                .Take(recipesPerPage)
                .Select(r => new RecipeHomeModel()
                {
                    Name = r.Name,
                    IsPrivate = r.IsPrivate,
                    CategoryName = r.Category.Name,
                    DifficultyName = r.Difficulty.Name,
                    DateAdded = r.DateAdded.ToString("dd/MM"),
                    ImageUrl = r.ImageUrl,
                    Rating = r.Rating.Average(),
                    UserName = r.User.ProfileName,
                    UserId = r.User.Id
                })
                .ToListAsync();

            result.TotalRecipesCount = await recipes.CountAsync();

            return result;
        }

        public async Task<int> Create(RecipeModel model)
        {
            var recipe = new Recipe()
            {
                Name = model.Name,
                Descipriton = model.Description,
                DateAdded = DateTime.Now,
                IsPrivate = model.IsPrivate,
                DifficultyId = model.DifficultyId,
                CategoryId = model.CategoryId,
                TimeForCooking = model.TimeForCooking,
                TimeForPreparation = model.TimeForPreparation,
                UserId = model.UserId,
                PortionsCount = model.PortionsCount
            };

            await repo.AddAsync(recipe);

            var user = await repo.GetByIdAsync<ApplicationUser>(recipe.UserId);
            user.Points += 10;

            await repo.SaveChangesAsync();

            return recipe.Id;
        }

        public async Task<bool> CategoryExists(int categoryId)
        {
            return await repo.AllReadonly<Category>()
                .AnyAsync(c => c.Id == categoryId);
        }

        public async Task<bool> DifficultyExists(int difficultyId)
        {
            return await repo.AllReadonly<Difficulty>()
                .AnyAsync(c => c.Id == difficultyId);
        }

        public async Task<RecipeDetailsModel> RecipeDetailsById(int id, string userId)
        {
            return await repo.AllReadonly<Recipe>()
                .Where(r => (r.IsPrivate == false || r.UserId == userId) && r.IsDeleted == false)
                .Where(r => r.Id == id)
                .Select(r => new RecipeDetailsModel()
                {
                    Id = r.Id,
                    AvatarImgUrl = r.User.AvatarImageUrl,
                    ProfileName = r.User.ProfileName,
                    ImageUrl = r.ImageUrl,
                    TimeForPreparation = r.TimeForPreparation,
                    TimeForCooking = r.TimeForCooking,
                    PortionsCount = r.PortionsCount,
                    Description = r.Descipriton,
                    Name = r.Name,
                    DateAdded = r.DateAdded.ToString("dd'.'MM'.'yyyy", CultureInfo.InvariantCulture),
                    CategoryId = r.CategoryId,
                    DifficultyId = r.DifficultyId,
                    UserId = r.UserId,
                    UserPoints = r.User.Points
                })
                .FirstAsync();
        }

        public async Task<bool> Exists(int id, string userId)
        {
            return await repo.AllReadonly<Recipe>()
                .AnyAsync(r => r.Id == id && (r.IsPrivate == false || r.UserId == userId) && r.IsDeleted == false);
        }

        public async Task<bool> RecipeWithUserId(int id, string userId)
        {
            return await repo.AllReadonly<Recipe>()
                .AnyAsync(r => r.Id == id && r.UserId == userId);
        }

        public async Task Edit(int recipeId, RecipeModel model)
        {
            var recipe = await repo.GetByIdAsync<Recipe>(recipeId);

            recipe.Name = model.Name;
            recipe.IsPrivate = model.IsPrivate;
            recipe.Descipriton = model.Description;
            recipe.ImageUrl = model.ImageUrl;
            recipe.PortionsCount = model.PortionsCount;
            recipe.TimeForCooking = model.TimeForCooking;
            recipe.TimeForPreparation = model.TimeForPreparation;
            recipe.DifficultyId = model.DifficultyId;
            recipe.CategoryId = model.CategoryId;

            await repo.SaveChangesAsync();
        }

        public async Task<int> GetRecipeCategoryId(int recipeId)
        {
            return (await repo.GetByIdAsync<Recipe>(recipeId)).CategoryId;
        }

        public async Task<int> GetRecipeDifficultyId(int recipeId)
        {
            return (await repo.GetByIdAsync<Recipe>(recipeId)).DifficultyId;
        }

        public async Task Delete(int id)
        {
            var recipe = await repo.GetByIdAsync<Recipe>(id);
            recipe.IsDeleted = true;

            await repo.SaveChangesAsync();
        }

        public async Task<ICollection<string>> AllCategoriesNames()
        {
            return await repo.AllReadonly<Category>()
                .OrderBy(c => c.Name)
                .Select(c => c.Name)
                .ToListAsync();
        }

        public async Task<ICollection<string>> AllDifficultiesNames()
        {
            return await repo.AllReadonly<Difficulty>()
                .OrderBy(d=> d.Name)
                .Select(d => d.Name)
                .ToListAsync();
        }

        public async Task<ICollection<RecipeHomeModel>> AllRecipesUnordered(string userId)
        {
            return await repo.AllReadonly<Recipe>()
                .Where(r => (r.IsPrivate == false || r.UserId == userId) && r.IsDeleted == false)
                .Where(r => r.UserId == userId)
                .OrderByDescending(r => r.DateAdded)
                .Select(r => new RecipeHomeModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    DifficultyName = r.Difficulty.Name,
                    CategoryName = r.Category.Name,
                    ImageUrl = r.ImageUrl,
                    IsPrivate = r.IsPrivate,
                    Rating = r.Rating.Any() ? r.Rating.Average() : 0,
                    DateAdded = r.DateAdded.ToString("dd/MM"),
                    UserName = r.User.ProfileName
                })
                .ToListAsync();
        }
    }
}

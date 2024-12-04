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

        public async Task<ICollection<RecipeHomeModel>> LastSixRecipes(string userId)
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
                    Images = r.Images,
                    IsPrivate = r.IsPrivate,
                    Rating = r.Rating.Average(),
                    DateAdded = r.DateAdded.ToString("dd/MM"),
                    UserName = r.User.ProfileName
                })
                .Take(6)
                .ToListAsync();
        }

        public async Task<ICollection<RecipeHomeModel>> AllRecipesOrdered(string userId)
        {
            return await repo.AllReadonly<Recipe>()
                .Where(r => (r.IsPrivate == false || r.UserId == userId) && r.IsDeleted == false)
                .OrderByDescending(r => r.Rating)
                .ThenByDescending(r => r.DateAdded)
                .Select(r => new RecipeHomeModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    DifficultyName = r.Difficulty.Name,
                    CategoryName = r.Category.Name,
                    Images = r.Images,
                    IsPrivate = r.IsPrivate,
                    Rating = r.Rating.Any() ? r.Rating.Average() : 0,
                    DateAdded = r.DateAdded.ToString("dd/MM"),
                    UserName = r.User.ProfileName
                })
                .ToListAsync();
        }

        public async Task<int> Create(RecipeModel model)
        {
            List<string> products = model.Products.Split(Environment.NewLine).ToList();

            var recipe = new Recipe()
            {
                Name = model.Name,
                Descipriton = model.Description,
                DateAdded = DateTime.Now,
                Images = GetModelImages(model),
                IsPrivate = model.IsPrivate,
                DifficultyId = model.DifficultyId,
                CategoryId = model.CategoryId,
                TimeForCooking = model.TimeForCooking,
                TimeForPreparation = model.TimeForPreparation,
                UserId = model.UserId,
                PortionsCount = model.PortionsCount,
                Products = products
            };

            await repo.AddAsync(recipe);
            await repo.SaveChangesAsync();
            recipe.User.Points += 10;

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
                    AvatarImgUrl = r.User.AvatarImageUrl,
                    ProfileName = r.User.ProfileName,
                    Points = r.User.Points,
                    ImagesUrl = r.Images.Select(i => i.ImageUrl).ToList(),
                    TimeForPreparation = r.TimeForPreparation,
                    TimeForCooking = r.TimeForCooking,
                    PortionsCount = r.PortionsCount,
                    Products = r.Products,
                    Description = r.Descipriton,
                    Name = r.Name,
                    DateAdded = r.DateAdded.ToString("dd'.'MM'.'yyyy", CultureInfo.InvariantCulture),
                    CategoryId = r.CategoryId,
                    DifficultyId = r.DifficultyId
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
            recipe.Images = GetModelImages(model);
            recipe.PortionsCount = model.PortionsCount;
            recipe.Products = model.Products.Split(Environment.NewLine).ToList();
            recipe.TimeForCooking = model.TimeForCooking;
            recipe.TimeForPreparation = model.TimeForPreparation;
            recipe.DifficultyId = model.DifficultyId;
            recipe.CategoryId = model.CategoryId;

            await repo.SaveChangesAsync();
        }

        private List<Image> GetModelImages(RecipeModel model)
        {
            List<Image> images = new List<Image>();

            foreach (var imageUrl in model.ImageUrls.Split(Environment.NewLine))
            {
                Image img = new()
                {
                    ImageUrl = imageUrl,
                    RecipeId = model.Id
                };

                images.Add(img);
            }

            return images;
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
    }
}

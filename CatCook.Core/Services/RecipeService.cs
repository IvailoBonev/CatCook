using CatCook.Core.Contracts;
using CatCook.Core.Models;
using CatCook.Infrastructure.Common;
using CatCook.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRepository repo;

        public RecipeService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<RecipeCategoryModel>> AllCategories()
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

        public async Task<IEnumerable<RecipeDifficultyModel>> AllDifficulties()
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

        public async Task<IEnumerable<RecipeHomeModel>> LastSixRecipes()
        {
            return await repo.AllReadonly<Recipe>()
                .Where(r => r.IsPrivate == false)
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

        public async Task<IEnumerable<RecipeHomeModel>> AllRecipesOrdered()
        {
            return await repo.AllReadonly<Recipe>()
                .Where(r => r.IsPrivate == false)
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
            List<Image> images = new List<Image>();

            foreach (var imageUrl in model.ImageUrls.Split(Environment.NewLine))
            {
                Image img = new()
                {
                    ImageUrl = imageUrl,
                    RecipeId = model.Id,
                    UserId = model.UserId
                };

                images.Add(img);
            }

            List<string> products = model.Products.Split(Environment.NewLine).ToList();

            var recipe = new Recipe()
            {
                Name = model.Name,
                Descipriton = model.Description,
                DateAdded = DateTime.Now,
                Images = images,
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
    }
}

using CatCook.Core.Contracts;
using CatCook.Core.Models;
using CatCook.Infrastructure.Common;
using CatCook.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
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
                    Rating = r.Rating,
                    DateAdded = r.DateAdded.ToString()
                })
                .Take(6)
                .ToListAsync();
        }
    }
}

using CatCook.Core.Models;
using CatCook.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Contracts
{
    public interface IRecipeService
    {
        Task<ICollection<RecipeHomeModel>> LastSixRecipes(string userId);

        Task<ICollection<RecipeHomeModel>> AllRecipesOrdered(string userId);

        Task<ICollection<RecipeCategoryModel>> AllCategories();

        Task<ICollection<RecipeDifficultyModel>> AllDifficulties();

        Task<int> GetRecipeCategoryId(int recipeId);

        Task<int> GetRecipeDifficultyId(int recipeId);

        Task<bool> CategoryExists(int categoryId);

        Task<bool> DifficultyExists(int difficultyId);

        Task<int> Create(RecipeModel model);

        Task<RecipeDetailsModel> RecipeDetailsById(int id, string userId);

        Task Edit(int recipeId, RecipeModel model);

        Task<bool> Exists(int id, string userId);

        Task<bool> RecipeWithUserId(int id, string userId);
    }
}

using CatCook.Core.Models.Recipe;
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
        Task<ICollection<RecipeHomeModel>> LastFourRecipes(string userId);

        Task<RecipeQueryModel> AllRecipes(string userId,
            string? category = null,
            string? difficulty = null,
            string? searchTerm = null, 
            RecipeSorting sorting = RecipeSorting.Newest, 
            int currentPage = 1, int recipesPerPage = 1);

        Task<ICollection<RecipeCategoryModel>> AllCategories();

        Task<ICollection<string>> AllCategoriesNames();

        Task<ICollection<RecipeDifficultyModel>> AllDifficulties();

        Task<ICollection<string>> AllDifficultiesNames();

        Task<int> GetRecipeCategoryId(int recipeId);

        Task<int> GetRecipeDifficultyId(int recipeId);

        Task<bool> CategoryExists(int categoryId);

        Task<bool> DifficultyExists(int difficultyId);

        Task<int> Create(RecipeModel model);

        Task<RecipeDetailsModel> RecipeDetailsById(int id, string userId);

        Task Edit(int recipeId, RecipeModel model);

        Task<bool> Exists(int id, string userId);

        Task<bool> RecipeWithUserId(int id, string userId);

        Task Delete(int id);
    }
}

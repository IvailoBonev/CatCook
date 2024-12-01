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
        Task<IEnumerable<RecipeHomeModel>> LastSixRecipes();

        Task<IEnumerable<RecipeHomeModel>> AllRecipesOrdered();

        Task<IEnumerable<RecipeCategoryModel>> AllCategories();

        Task<IEnumerable<RecipeDifficultyModel>> AllDifficulties();

        Task<bool> CategoryExists(int categoryId);

        Task<bool> DifficultyExists(int difficultyId);

        Task<int> Create(RecipeModel model);
    }
}

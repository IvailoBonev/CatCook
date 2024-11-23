using CatCook.Core.Models;
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

        Task<IEnumerable<RecipeCategoryModel>> AllCategories();

        Task<IEnumerable<RecipeDifficultyModel>> AllDifficulties();
    }
}

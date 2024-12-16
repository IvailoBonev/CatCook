using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Models.Recipe
{
    public class RecipeQueryModel
    {
        public int TotalRecipesCount { get; set; }

        public IEnumerable<RecipeHomeModel> Recipes { get; set; } = new List<RecipeHomeModel>();
    }
}

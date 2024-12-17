using CatCook.Core.Models.Recipe;

namespace CatCook.Models
{
    public class AllRecipesQueryModel
    {
        public const int RecipesPerPage = 8;

        public string? Category { get; set; }

        public string? Difficulty { get; set; }

        public string? SearchTerm { get; set; } 

        public RecipeSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalRecipesCount { get; set; }

        public IEnumerable<string> Categories { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> Difficulties { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<RecipeHomeModel> Recipes { get; set; } = Enumerable.Empty<RecipeHomeModel>();
    }
}

using CatCook.Core.Models.Recipe;
using CatCook.Core.Models.Tip;

namespace CatCook.Models
{
    public class AllTipsQueryModel
    {
        public const int TipsPerPage = 6;

        public string? SearchTerm { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalTipsCount { get; set; }

        public IEnumerable<TipHomeModel> Tips { get; set; } = Enumerable.Empty<TipHomeModel>();
    }
}

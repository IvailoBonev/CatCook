
using CatCook.Core.Models.Forum;

namespace CatCook.Models
{
    public class AllForumsQueryModel
    {
        public const int ForumsPerPage = 5;

        public string? SearchTerm { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalForumsCount { get; set; }

        public IEnumerable<ForumHomeModel> Forums { get; set; } = Enumerable.Empty<ForumHomeModel>();
    }
}

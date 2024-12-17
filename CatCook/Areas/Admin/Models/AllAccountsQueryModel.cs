using CatCook.Core.Models.Account;
using CatCook.Core.Models.Forum;

namespace CatCook.Areas.Admin.Models
{
    public class AllAccountsQueryModel
    {
        public const int AccountsPerPage = 6;

        public string? SearchTerm { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalAccountsCount { get; set; }

        public IEnumerable<AccountDetailsModel> Accounts { get; set; } = Enumerable.Empty<AccountDetailsModel>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Models.Account
{
    public class AccountQueryModel
    {
        public int TotalAccountsCount { get; set; }

        public IEnumerable<AccountDetailsModel> Accounts { get; set; } = new List<AccountDetailsModel>();
    }
}

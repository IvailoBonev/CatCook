using CatCook.Core.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Contracts
{
    public interface IAccountService
    {
        public Task<AccountQueryModel> AllAccounts(string? searchTerm = null,
            int currentPage = 1, int accountsPerPage = 1);

        public Task<AccountDetailsModel> AccountDetailsById(string userId);

        Task<bool> Exists(string userId);

        Task Delete(string id);
    }
}

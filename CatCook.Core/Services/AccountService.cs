using CatCook.Core.Contracts;
using CatCook.Core.Models.Account;
using CatCook.Core.Models.Tip;
using CatCook.Infrastructure.Common;
using CatCook.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Services
{
    public class AccountService : IAccountService
    {
        private readonly IRepository repo;

        public AccountService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<AccountDetailsModel> AccountDetailsById(string userId)
        {
            return await repo.AllReadonly<ApplicationUser>()
                .Where(a => a.Id == userId)
                .Select(a => new AccountDetailsModel
                {
                    Email = a.Email,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    AvatarImgUrl = a.AvatarImageUrl,
                    ProfileName = a.ProfileName,
                    Status = a.Status,
                    City = a.City,
                    UserPoints = a.Points
                }).FirstAsync();
        }

        public async Task<bool> Exists(string userId)
        {
            return await repo.AllReadonly<ApplicationUser>()
               .AnyAsync(a => a.Id == userId);
        }
    }
}

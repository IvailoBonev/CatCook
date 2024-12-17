using CatCook.Core.Contracts;
using CatCook.Core.Models.Account;
using CatCook.Core.Models.Comment;
using CatCook.Core.Models.Forum;
using CatCook.Core.Models.Recipe;
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
                    Id = a.Id,
                    Email = a.Email,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    AvatarImgUrl = a.AvatarImageUrl,
                    ProfileName = a.ProfileName,
                    Status = a.Status,
                    City = a.City,
                    UserPoints = a.Points,
                    Recipes = a.UserRecipes
                        .Where(r => (r.IsPrivate == false || r.UserId == userId) && r.IsDeleted == false)
                        .Select(r => new RecipeHomeModel
                        {
                            Id = r.Id,
                            Name = r.Name,
                            ImageUrl = r.ImageUrl,
                            DifficultyName = r.Difficulty.Name,
                            Rating = r.Rating.Any() ? r.Rating.Average() : 0.0,
                            DateAdded = r.DateAdded.ToString("dd.MM.yyyy"),
                            UserName = r.User.ProfileName,
                            IsPrivate = r.IsPrivate,
                            CategoryName = r.Category.Name,
                            UserId = r.UserId
                        }).ToList(),
                    Forums = a.Forums   
                        .Where(f => f.IsDeleted == false)
                        .Select(f => new ForumHomeModel
                        {
                            Id =f.Id,
                            Title = f.Title,
                            Text = f.Text,
                            ProfileName = f.User.ProfileName,
                            DateAdded = f.DateAdded.ToString("dd/MM"),
                            AvatarUrlImage = f.User.AvatarImageUrl,
                            CommentsCount = f.Comments.Where(c => c.IsDeleted == false).Count(),
                            UserId = f.UserId
                        }).ToList(),
                    Comments = a.Comments
                        .Where(a => a.IsDeleted == false)
                        .Select(c => new CommentViewModel
                        {
                            Id = c.Id,
                            Text = c.Text,
                            Title = c.Title,
                            ProfileName = c.User.ProfileName,
                            ForumId = c.ForumId,
                            AvatarImgUrl = c.User.AvatarImageUrl,
                            DateAdded= c.DateAdded.ToString("dd/MM"),
                            UserId = c.UserId
                        }).ToList(),
                    Tips = a.Tips
                        .Where(t => t.IsDeleted == false)
                        .Select(t => new TipHomeModel
                        {
                            Id = t.Id,
                            Description = t.Description,
                            ProfileName= t.User.ProfileName,
                            Title = t.Title,
                            DateAdded = t.DateAdded.ToString("dd/MM")
                        }).ToList()
                }).FirstAsync();
        }

        public async Task<AccountQueryModel> AllAccounts(
            string? searchTerm = null,
            int currentPage = 1, int accountsPerPage = 1)
        {
            var result = new AccountQueryModel();
            var accounts = repo.AllReadonly<ApplicationUser>()
                .Where(t => t.IsDeleted == false);

            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                searchTerm = $"%{searchTerm.ToLower()}%";

                accounts = accounts
                    .Where(a => EF.Functions.Like(a.ProfileName.ToLower(), searchTerm));
            }

            result.Accounts = await accounts
                .Skip((currentPage - 1) * accountsPerPage)
                .Take(accountsPerPage)
                .Select(a => new AccountDetailsModel
                {
                    Id = a.Id,
                    Email = a.Email,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    AvatarImgUrl = a.AvatarImageUrl,
                    ProfileName = a.ProfileName,
                    Status = a.Status,
                    City = a.City,
                    UserPoints = a.Points
                }).ToListAsync();

            result.TotalAccountsCount = await accounts.CountAsync();

            return result;
        }

        public async Task<bool> Exists(string userId)
        {
            return await repo.AllReadonly<ApplicationUser>()
               .AnyAsync(a => a.Id == userId);
        }
    }
}

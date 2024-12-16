using AngleSharp;
using AngleSharp.Html.Parser;
using CatCook.Core.Contracts;
using CatCook.Core.Models.Recipe;
using CatCook.Core.Models.Tip;
using CatCook.Infrastructure.Common;
using CatCook.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CatCook.Core.Services
{
    public class TipService : ITipService
    {
        private readonly IRepository repo;

        public TipService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<TipQueryModel> AllTips(
            string? searchTerm = null,
            int currentPage = 1, int tipsPerPage = 1)
        {
            var result = new TipQueryModel();
            var tips = repo.AllReadonly<Tip>()
                .Where(t => t.IsDeleted == false);

            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                searchTerm = $"%{searchTerm.ToLower()}%";

                tips = tips
                    .Where(t => EF.Functions.Like(t.Title.ToLower(), searchTerm));
            }

            result.Tips = await tips
                .Skip((currentPage - 1) * tipsPerPage)
                .Take(tipsPerPage)
                .Select(t => new TipHomeModel()
                {
                    Title = t.Title,
                    Description = t.Description,
                    DateAdded = t.DateAdded.ToString("dd/MM"),
                    ProfileName = t.User.ProfileName,
                    Id = t.Id
                })
                .ToListAsync();

            result.TotalTipsCount = await tips.CountAsync();

            return result;
        }

        public async Task<int> Create(TipModel model)
        {
            var tip = new Tip()
            {
                Id = model.Id,
                UserId = model.UserId,
                Description = model.Description,
                Title = model.Title,
                DateAdded = model.DateAdded
            };
            
            await repo.AddAsync(tip);

            var user = await repo.GetByIdAsync<ApplicationUser>(tip.UserId);
            user.Points += 5;

            await repo.SaveChangesAsync();
            return model.Id;
        }

        public async Task Delete(int id)
        {
            var tip = await repo.GetByIdAsync<Tip>(id);
            tip.IsDeleted = true;

            await repo.SaveChangesAsync();
        }

        public async Task Edit(int tipId, TipModel model)
        {
            var tip = await repo.GetByIdAsync<Tip>(tipId);

            tip.Title = model.Title;
            tip.Description = model.Description;

            await repo.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await repo.AllReadonly<Tip>()
                .AnyAsync(t => t.Id == id && t.IsDeleted == false);
        }

        public async Task<ICollection<TipHomeModel>> LastFourTips()
        {
            return await repo.AllReadonly<Tip>()
                .Where(r => r.IsDeleted == false)
                .OrderByDescending(r => r.DateAdded)
                .Select(r => new TipHomeModel()
                {
                    Id = r.Id,
                    Title = r.Title,
                    Description = r.Description,
                    DateAdded = r.DateAdded.ToString("dd'.'MM'.'yyyy", CultureInfo.InvariantCulture),
                    IsDeleted = r.IsDeleted,
                    ProfileName = r.User.ProfileName
                })
                .Take(4)
                .ToListAsync();
        }

        public async Task<TipDetailsModel> TipDetailsById(int id)
        {
             return await repo.AllReadonly<Tip>()
                .Where(t => t.Id == id && t.IsDeleted == false)
                .Select(t => new TipDetailsModel
                {
                    Id = t.Id,
                    Title = t.Title,
                    DateAdded = t.DateAdded.ToString("dd'.'MM'.'yyyy", CultureInfo.InvariantCulture),
                    Description = t.Description,
                    AvatarImgUrl = t.User.AvatarImageUrl,
                    ProfileName = t.User.ProfileName,
                    UserId = t.UserId,
                    UserPoints = t.User.Points
                }).FirstAsync();
        }

        public async Task<bool> TipWithUserId(int id, string userId)
        {
            return await repo.AllReadonly<Tip>()
                .AnyAsync(t => t.Id == id && t.UserId == userId);
        }
    }
}

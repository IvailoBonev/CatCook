using AngleSharp;
using AngleSharp.Html.Parser;
using CatCook.Core.Contracts;
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

namespace CatCook.Core.Services
{
    public class TipService : ITipService
    {
        private readonly IRepository repo;

        public TipService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<ICollection<TipHomeModel>> AllRecipesOrdered()
        {
            return await repo.AllReadonly<Tip>()
                .Where(t => t.IsDeleted == false)
                .OrderByDescending(t => t.DateAdded)
                .Select(t => new TipHomeModel
                {
                    Id = t.Id,
                    Title = t.Title,
                    Description = t.Description,
                    ProfileName = t.User.ProfileName,
                    IsDeleted = t.IsDeleted,
                    DateAdded = t.DateAdded.ToString("dd/MM")
                }).ToListAsync();
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
            await repo.SaveChangesAsync();
            return model.Id;
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
                    ProfileName = t.User.ProfileName
                }).FirstAsync();
        }
    }
}

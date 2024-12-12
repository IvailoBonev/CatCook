using CatCook.Core.Contracts;
using CatCook.Core.Models.Forum;
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
    public class ForumService : IForumService
    {
        private readonly IRepository repo;

        public ForumService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<ICollection<ForumHomeModel>> AllForumsOrdered()
        {
            return await repo.AllReadonly<Forum>()
                .Where(f => f.IsDeleted == false)
                .OrderByDescending(r => r.DateAdded)
                .Select(f => new ForumHomeModel()
                {
                    Id = f.Id,
                    Title = f.Title,
                    Text = f.Text,
                    DateAdded = f.DateAdded.ToString("dd'.'MM'.'yyyy", CultureInfo.InvariantCulture),
                    ProfileName = f.User.ProfileName,
                    UserId = f.User.Id,
                    AvatarUrlImage = f.User.AvatarImageUrl,
                    CommentsCount = f.Comments.Count
                })
                .ToListAsync();
        }

        public async Task<int> Create(ForumModel model)
        {
            var forum = new Forum()
            {
                Id = model.Id,
                UserId = model.UserId,
                Text = model.Text,
                Title = model.Title,
                DateAdded = model.DateAdded
            };

            await repo.AddAsync(forum);

            var user = await repo.GetByIdAsync<ApplicationUser>(forum.UserId);
            user.Points += 20;

            await repo.SaveChangesAsync();
            return model.Id;
        }

        public async Task Delete(int id)
        {
            var forum = await repo.GetByIdAsync<Forum>(id);
            forum.IsDeleted = true;

            await repo.SaveChangesAsync();
        }

        public async Task Edit(int forumId, ForumModel model)
        {
            var forum = await repo.GetByIdAsync<Forum>(forumId);

            forum.Title = model.Title;
            forum.Text = model.Text;

            await repo.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await repo.AllReadonly<Forum>()
                 .AnyAsync(t => t.Id == id && t.IsDeleted == false);
        }

        public async Task<ForumDetailsModel> ForumDetailsById(int id)
        {
            return await repo.AllReadonly<Forum>()
                .Where(f => f.Id == id && f.IsDeleted == false)
                .Select(f => new ForumDetailsModel
                {
                    Id = f.Id,
                    Title = f.Title,
                    DateAdded = f.DateAdded.ToString("dd'.'MM'.'yyyy", CultureInfo.InvariantCulture),
                    Text = f.Text,
                    AvatarImageUrl = f.User.AvatarImageUrl,
                    CommentCount = f.Comments.Count(),
                    ProfileName = f.User.ProfileName,
                    UserId = f.User.Id
                }).FirstAsync();
        }

        public async Task<bool> ForumWithUserId(int id, string userId)
        {
            return await repo.AllReadonly<Forum>()
                .AnyAsync(f => f.Id == id && f.UserId == userId && f.IsDeleted == false);
        }

        public async Task<ICollection<ForumHomeModel>> LastFourForums()
        {
            return await repo.AllReadonly<Forum>()
                .Where(f => f.IsDeleted == false)
                .OrderByDescending(r => r.DateAdded)
                .Select(f => new ForumHomeModel()
                {
                    Id = f.Id,
                    Title = f.Title,
                    Text = f.Text,
                    DateAdded = f.DateAdded.ToString("dd'.'MM'.'yyyy", CultureInfo.InvariantCulture),
                    ProfileName = f.User.ProfileName,
                    UserId = f.User.Id,
                    AvatarUrlImage = f.User.AvatarImageUrl,
                    CommentsCount = f.Comments.Count
                })
                .Take(4)
                .ToListAsync();
        }
    }
}

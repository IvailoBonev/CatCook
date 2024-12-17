using CatCook.Core.Contracts;
using CatCook.Core.Models.Comment;
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
    public class CommentService : ICommentService
    {
        private readonly IRepository repo;

        public CommentService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<ICollection<CommentViewModel>> AllCommentsOrdered(string userId)
        {
            return await repo.AllReadonly<Comment>()
                .Where(c => c.IsDeleted == false && c.UserId == userId)
                .OrderByDescending(c => c.DateAdded)
                .Select(c => new CommentViewModel
                {
                    Id = c.Id,
                    Title = c.Title,
                    Text = c.Text,
                    ForumId = c.ForumId,
                    DateAdded = c.DateAdded.ToString("dd/MM"),
                    AvatarImgUrl = c.User.AvatarImageUrl,
                    ProfileName = c.User.ProfileName,
                    UserId = c.UserId
                }).ToListAsync();
        }

        public async Task<CommentViewModel> CommentDetailsById(int id)
        {
            return await repo.AllReadonly<Comment>()
                 .Where(c => c.Id == id && c.IsDeleted == false)
                 .Select(c => new CommentViewModel
                 {
                     Id = c.Id,
                     Title = c.Title,
                     DateAdded = c.DateAdded.ToString("dd'.'MM'.'yyyy", CultureInfo.InvariantCulture),
                     Text = c.Text,
                     AvatarImgUrl = c.User.AvatarImageUrl,
                     ProfileName = c.User.ProfileName,
                     UserId = c.UserId,
                     ForumId = c.ForumId,
                 }).FirstAsync();
        }

        public async Task<bool> CommentWithUserId(int id, string userId, bool isAdmin)
        {
            return await repo.AllReadonly<Comment>()
                .AnyAsync(c => c.Id == id && (c.UserId == userId || isAdmin));
        }

        public async Task<int> Create(CommentModel model)
        {
            var comment = new Comment()
            {
                UserId = model.UserId,
                Title = model.Title,
                Text = model.Text,  
                DateAdded = model.DateAdded,
                ForumId = model.ForumId
            };

            await repo.AddAsync(comment);

            var user = await repo.GetByIdAsync<ApplicationUser>(comment.UserId);
            user.Points += 5;

            await repo.SaveChangesAsync();
            return model.Id;
        }

        public async Task Delete(int id)
        {
            var comment = await repo.GetByIdAsync<Comment>(id);
            comment.IsDeleted = true;

            await repo.SaveChangesAsync();
        }

        public async Task Edit(int commentId, CommentModel model)
        {
            var comment = await repo.GetByIdAsync<Comment>(commentId);

            comment.Title = model.Title;
            comment.Text = model.Text;

            await repo.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await repo.AllReadonly<Comment>()
               .AnyAsync(c => c.Id == id && c.IsDeleted == false);
        }
    }
}

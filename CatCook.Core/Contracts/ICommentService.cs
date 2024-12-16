using CatCook.Core.Models.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Contracts
{
    public interface ICommentService
    {
        Task<ICollection<CommentViewModel>> AllCommentsOrdered(string userId);

        Task<int> Create(CommentModel model);

        Task<CommentViewModel> CommentDetailsById(int id);

        Task<bool> Exists(int id);

        Task Edit(int commentId, CommentModel model);

        Task<bool> CommentWithUserId(int id, string userId);

        Task Delete(int id);
    }
}

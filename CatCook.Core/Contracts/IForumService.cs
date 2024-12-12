using CatCook.Core.Models.Forum;
using CatCook.Core.Models.Tip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Contracts
{
    public interface IForumService
    {
        Task<ICollection<ForumHomeModel>> LastFourForums();

        Task<ICollection<ForumHomeModel>> AllForumsOrdered();

        Task<int> Create(ForumModel model);

        Task<ForumDetailsModel> ForumDetailsById(int id);

        Task<bool> Exists(int id);

        Task Edit(int forumId, ForumModel model);

        Task<bool> ForumWithUserId(int id, string userId);

        Task Delete(int id);
    }
}

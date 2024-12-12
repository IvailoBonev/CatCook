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
    }
}

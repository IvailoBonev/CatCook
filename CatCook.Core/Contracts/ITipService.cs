using CatCook.Core.Models.Recipe;
using CatCook.Core.Models.Tip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Contracts
{
    public interface ITipService
    {
        Task<ICollection<TipHomeModel>> LastFourTips();

        Task<TipQueryModel> AllTips(string? searchTerm = null,
            int currentPage = 1, int tipsPerPage = 1);

        Task<int> Create(TipModel model);

        Task<TipDetailsModel> TipDetailsById(int id);

        Task<bool> Exists(int id);

        Task Edit(int tipId, TipModel model);

        Task<bool> TipWithUserId(int id, string userId);

        Task Delete(int id);
    }
}

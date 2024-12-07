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
        Task<ICollection<TipHomeModel>> AllRecipesOrdered();

        Task<int> Create(TipModel model);

        Task<TipDetailsModel> TipDetailsById(int id);

        Task<bool> Exists(int id);
    }
}

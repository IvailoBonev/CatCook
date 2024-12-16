using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Models.Tip
{
    public class TipQueryModel
    {
        public int TotalTipsCount { get; set; }

        public IEnumerable<TipHomeModel> Tips { get; set; } = new List<TipHomeModel>();
    }
}

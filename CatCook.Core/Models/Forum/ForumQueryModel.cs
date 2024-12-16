using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Models.Forum
{
    public class ForumQueryModel
    {
        public int TotalForumsCount { get; set; }

        public IEnumerable<ForumHomeModel> Forums { get; set; } = new List<ForumHomeModel>();
    }
}

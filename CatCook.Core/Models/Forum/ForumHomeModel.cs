using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Models.Forum
{
    public class ForumHomeModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public string ProfileName { get; set; } = string.Empty;
        public string AvatarUrlImage { get; set; } = string.Empty;
        public string DateAdded { get; set; } = string.Empty;
        public int CommentsCount { get; set; }
    }
}

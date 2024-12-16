using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Models.Comment
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public string DateAdded { get; set; } = string.Empty;
        public string AvatarImgUrl { get; set; } = string.Empty;
        public string ProfileName { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public int ForumId { get; set; }
    }
}

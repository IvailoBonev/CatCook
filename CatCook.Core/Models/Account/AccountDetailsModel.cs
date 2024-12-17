using CatCook.Core.Models.Comment;
using CatCook.Core.Models.Forum;
using CatCook.Core.Models.Recipe;
using CatCook.Core.Models.Tip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Models.Account
{
    public class AccountDetailsModel
    {
        public string Id { get; set; } = string.Empty;
        public string ProfileName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string AvatarImgUrl { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int UserPoints { get; set; }

        public ICollection<RecipeHomeModel> Recipes { get; set; }
            = new List<RecipeHomeModel>();

        public ICollection<ForumHomeModel> Forums { get; set; }
            = new List<ForumHomeModel>();

        public ICollection<TipHomeModel> Tips { get; set; }
            = new List<TipHomeModel>();

        public ICollection<CommentViewModel> Comments { get; set; }
            = new List<CommentViewModel>();
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CatCook.Infrastructure.Common.Constants;
namespace CatCook.Infrastructure.Data
{
    public class ApplicationUser : IdentityUser<string>
    {
        [Required]
        [MaxLength(UserFirstNameMaxLength)]
        [Comment("The user's first name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(UserLastNameMaxLength)]
        [Comment("The user's last name")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [MaxLength(UserProfileNameMaxLength)]
        [Comment("The user's profile name")]
        public string ProfileName { get; set; } = string.Empty;

        [Comment("How many cooking points does the user have")]
        public int Points { get; set; }

        [MaxLength(UserCityNameMaxLength)]
        [Comment("The city of the user")]
        public string? City { get; set; }

        [MaxLength(UserUrlImageMaxLength)]
        [Comment("The user avatar image")]
        public string? AvatarImageUrl { get; set; }

        [MaxLength(UserStatusMaxLength)]
        [Comment("The user's status for today")]
        public string? Status { get; set; }

        [Comment("All recipes from this user")]
        public List<Recipe> UserRecipes { get; set; }
            = new List<Recipe>();

        [Comment("All images posted from this user")]
        public ICollection<Forum> Forums { get; set; } =
            new List<Forum>();

        [Comment("All tips posted from this user")]
        public ICollection<Tip> Tips { get; set; }
            = new List<Tip>();

        [Comment("All comments posted from this user")]
        public ICollection<Comment> Comments { get; set; }
            = new List<Comment>();

        [Comment("The user's friends")]
        public ICollection<ApplicationUser> Friends { get; set; }
            = new List<ApplicationUser>();
    }
}

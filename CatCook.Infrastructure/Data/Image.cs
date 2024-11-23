using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CatCook.Infrastructure.Common.Constants;

namespace CatCook.Infrastructure.Data
{
    public class Image
    {
        [Key]
        [Comment("Image identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("The url of the image")]
        [MaxLength(ImageUrlMaxLength)]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        [Comment("Who uploaded the image")]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public int RecipeId { get; set; }

        [ForeignKey(nameof(RecipeId))]
        [Comment("The forum wheere the image was uploaded")]
        public Recipe Recipe { get; set; } = null!;
    }
}
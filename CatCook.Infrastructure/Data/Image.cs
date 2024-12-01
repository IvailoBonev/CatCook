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
        public int RecipeId { get; set; }

        [ForeignKey(nameof(RecipeId))]
        [Comment("The forum wheere the image was uploaded")]
        public Recipe Recipe { get; set; } = null!;
    }
}
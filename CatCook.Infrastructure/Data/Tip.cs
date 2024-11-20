using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CatCook.Infrastructure.Common.Constants;

namespace CatCook.Infrastructure.Data
{
    public class Tip
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(TipImageUrlMaxLength)]
        public string? ImageUrl { get; set; }

        [Required]
        [MaxLength(TipTitleMaxLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(TipDescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
    }
}

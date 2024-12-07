using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CatCook.Infrastructure.Common.Constants;

namespace CatCook.Core.Models.Tip
{
    public class TipModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(TipTitleMaxLength,
            MinimumLength = TipTitleMinLength,
            ErrorMessage = TipTitleErrorMessage)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        public string UserId { get; set; } = string.Empty;
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CatCook.Infrastructure.Common.Constants;

namespace CatCook.Core.Models.Forum
{
    public class ForumModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(ForumTitleMaxLength,
            MinimumLength = ForumTitleMinLength,
            ErrorMessage = ForumTitleErrorMessage)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(ForumTextMaxLength,
            MinimumLength = ForumTextMinLength,
            ErrorMessage = ForumTextErrorMessage)]
        public string Text { get; set; } = string.Empty;

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        public string UserId { get; set; } = string.Empty;
    }
}

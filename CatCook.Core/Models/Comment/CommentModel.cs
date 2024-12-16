using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CatCook.Infrastructure.Common.Constants;

namespace CatCook.Core.Models.Comment
{
    public class CommentModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(CommentTitleMaxLength,
            MinimumLength = CommentTitleMinLength,
            ErrorMessage = CommentTitleErrorMessage)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(CommentTextMaxLength,
            MinimumLength = CommentTextMinLength,
            ErrorMessage = CommentTextErrorMessage)]
        public string Text { get; set; } = string.Empty;

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [Required]
        public int ForumId { get; set; }
    }
}

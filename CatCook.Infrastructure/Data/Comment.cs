using Microsoft.EntityFrameworkCore;
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
    public class Comment
    {
        [Key]
        [Comment("Comment identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Title of comment")]
        [MaxLength(CommentTitleMaxLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Comment("The comment content")]
        [MaxLength(CommentTextMaxLength)]
        public string Text { get; set; } = string.Empty;

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        [Comment("Which user commented")]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public int ForumId { get; set; }

        [ForeignKey(nameof(ForumId))]
        [Comment("Under which forum was the comment")]
        public Forum Forum { get; set; } = null!;
    }
}

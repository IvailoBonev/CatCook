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
    public class Forum
    {
        [Key]
        [Comment("Forum identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("The title of the forum")]
        [MaxLength(ForumTitleMaxLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Comment("The content of the forum")]
        [MaxLength(ForumTextMaxLength)]
        public string Text { get; set; } = string.Empty;

        [Required]
        public string UserId { get; set; } = string.Empty;

        [Required]
        [Comment("Is the forum deleted (soft delete)")]
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(UserId))]
        [Comment("Which user posted the forum")]
        public ApplicationUser User { get; set; } = null!;
    }
}

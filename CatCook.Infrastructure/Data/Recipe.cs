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
    public class Recipe
    {
        [Key]
        [Comment("Recipe identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Is the recipe private or public")]
        public bool IsPrivate { get; set; }

        [Required]
        [Comment("Is the recipe deleted (soft delete)")]
        public bool IsDeleted { get; set; }

        [Required]
        [Comment("The recipe name")]
        [MaxLength(RecipeNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("A description of the recipe")]
        public string Descipriton { get; set; } = string.Empty;

        [Required]
        public int DifficultyId { get; set; }

        [ForeignKey(nameof(DifficultyId))]
        [Comment("The difficulty of the recipe")]
        public Difficulty Difficulty { get; set; } = null!;

        [Required]
        [Comment("Time needed for preparation for cooking")]
        public int TimeForPreparation { get; set; }

        [Required]
        [Comment("Time needed for cooking")]
        public int TimeForCooking { get; set; }

        [Comment("The ratings of the recipe by users")]
        public List<double> Rating { get; set; } = new List<double>();

        [Required]
        [Comment("How many portions the recipe provides")]
        public int PortionsCount { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        [Comment("Which user uploaded the recipe")]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [Comment("In what category is the recipe placed")]
        public Category Category { get; set; } = null!;

        [Comment("Images used for the recipe")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}

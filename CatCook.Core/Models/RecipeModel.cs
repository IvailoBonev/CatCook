
using CatCook.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static CatCook.Infrastructure.Common.Constants;

namespace CatCook.Core.Models
{
    public class RecipeModel
    {
        [Required]
        public bool IsPrivate { get; set; }

        [Required]
        [StringLength(RecipeNameMaxLength,
            MinimumLength = RecipeNameMinLength,
            ErrorMessage = "Recipe name must be between {1} and {0} symbols!")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(RecipeDescriptionMaxLength,
            MinimumLength = RecipeDescriptionMinLength,
            ErrorMessage = "Recipe description must be between {1} and {0} symbols!")]
        public string Description { get; set; } = string.Empty;

        [Required]
        public ICollection<string> Products { get; set; }
            = new List<string>();

        [Required]
        public int DifficultyId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int TimeForPreparation { get; set; }

        [Required]
        public int TimeForCooking { get; set; }

        public List<double> Rating { get; set; } = new List<double>();

        [Required]
        public int PortionsCount { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        public ICollection<Image> Images { get; set; }
            = new List<Image>();

        public IEnumerable<RecipeCategoryModel> RecipeCategories { get; set; }
            = new List<RecipeCategoryModel>();

        public IEnumerable<RecipeDifficultyModel> RecipeDifficulties { get; set; }
            = new List<RecipeDifficultyModel>();

        [Required]
        public string UserId { get; set; } = string.Empty;
    }
}

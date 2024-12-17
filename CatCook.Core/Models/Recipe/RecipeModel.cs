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

namespace CatCook.Core.Models.Recipe
{
    public class RecipeModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool IsPrivate { get; set; }

        [Required]
        [StringLength(RecipeNameMaxLength,
            MinimumLength = RecipeNameMinLength,
            ErrorMessage = RecipeNameErrorMessage)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int DifficultyId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [Range(RecipePreparationTimeMin, RecipePreparationTimeMax,
            ErrorMessage = RecipePreparationErrorMessage)]
        public int TimeForPreparation { get; set; }

        [Required]
        [Range(RecipeCookingTimeMin, RecipeCookingTimeMax,
            ErrorMessage = RecipeCookingErrorMessage)]
        public int TimeForCooking { get; set; }


        [Required]
        [Range(RecipePortionsCountMin, RecipePortionsCountMax,
            ErrorMessage = RecipePortionsErrorMessage)]
        public int PortionsCount { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1, 5,
            ErrorMessage = RecipeRatingErrorMessage)]
        public double Rating { get; set; }

        public string? ImageUrl { get; set; }

        public ICollection<RecipeCategoryModel> RecipeCategories { get; set; }
            = new List<RecipeCategoryModel>();

        public ICollection<RecipeDifficultyModel> RecipeDifficulties { get; set; }
            = new List<RecipeDifficultyModel>();

        [Required]
        public string UserId { get; set; } = string.Empty;
    }
}

using CatCook.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CatCook.Infrastructure.Common.Constants;

namespace CatCook.Infrastructure.Data
{
    public class Category
    {
        [Key]
        [Comment("Category identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Category name")]
        [MaxLength(CategoryNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Comment("Which recipes have this category")]
        public List<Recipe> Recipes { get; set; }
            = new List<Recipe>();
    }
}

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
    public class Difficulty
    {
        public Difficulty()
        {
            Recipes = new List<Recipe>();
        }

        [Key]
        [Comment("Difficulty identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("The name of the difficulty")]
        [MaxLength(DifficultyNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Comment("Which recipes have this difficulty")]
        public List<Recipe> Recipes { get; set; }
    }
}

using CatCook.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Models.Recipe
{
    public class RecipeHomeModel
    {
        public int Id { get; set; }

        public bool IsPrivate { get; set; }

        public string Name { get; set; } = string.Empty;

        public string DateAdded { get; set; } = string.Empty;

        public string DifficultyName { get; set; } = string.Empty;

        public double Rating { get; set; }

        public string CategoryName { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public string UserId { get; set; } = string.Empty;
    }
}

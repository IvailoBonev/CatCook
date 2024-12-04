using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Models.Recipe
{
    public class RecipeDetailsModel
    {
        public string AvatarImgUrl { get; set; } = string.Empty;
        public string ProfileName { get; set; } = string.Empty;
        public int Points { get; set; }
        public ICollection<string> ImagesUrl { get; set; } = new List<string>();
        public int TimeForPreparation { get; set; }
        public int TimeForCooking { get; set; }
        public int PortionsCount { get; set; }
        public ICollection<string> Products { get; set; } = new List<string>();
        public string Description { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string DateAdded { get; set; } = string.Empty;
        public int DifficultyId { get; set; }
        public int CategoryId { get; set; }
        public bool IsPrivate { get; set; }
    }
}

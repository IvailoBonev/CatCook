using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Models.Tip
{
    public class TipDetailsModel
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string DateAdded { get; set; } = string.Empty;

        public string AvatarImgUrl { get; set; } = string.Empty;

        public string ProfileName { get; set; } = string.Empty;

        public int UserPoints { get; set; }
    }
}

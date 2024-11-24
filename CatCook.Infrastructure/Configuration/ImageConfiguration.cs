using CatCook.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Infrastructure.Configuration
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(CreateImages());
        }

        private List<Image> CreateImages()
        {
            var images = new List<Image>()
            {
                new Image()
                {
                    Id = 1,
                    ImageUrl = "https://feelgoodfoodie.net/wp-content/uploads/2020/04/Caesar-Salad-TIMG.jpg",
                    UserId = "36998a40-6007-4cea-ac6e-c191880fa9e8",
                    RecipeId = 1
                },
                new Image()
                {
                    Id = 2,
                    ImageUrl = "https://cakesbymk.com/wp-content/uploads/2023/11/Template-Size-for-Blog-Photos-24.jpg",
                    UserId = "36998a40-6007-4cea-ac6e-c191880fa9e8",
                    RecipeId = 2
                }
            };

            return images;
        }
    }
}

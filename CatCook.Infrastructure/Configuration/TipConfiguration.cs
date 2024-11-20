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
    public class TipConfiguration : IEntityTypeConfiguration<Tip>
    {
        public void Configure(EntityTypeBuilder<Tip> builder)
        {
            builder.HasData(CreateTips());
        }

        private List<Tip> CreateTips()
        {
            var tips = new List<Tip>()
            {
                new Tip()
                {
                    Id = 1,
                    ImageUrl = "https://cdn.ruled.me/wp-content/uploads/2017/11/zingy-lemon-fish-featured.jpg",
                    Title = "Elevate Your Fish Dishes with Lemon: A Simple Tip",
                    Description = "When cooking fish, lemons can be a game-changer for flavor! A great tip is to use lemon in layers throughout your cooking process. Start by marinating your fish with a mixture of lemon juice, olive oil, and your favorite herbs—this not only enhances the flavor but also tenderizes the fish.\r\n\r\nDuring cooking, add thin slices of lemon directly on top of the fish. This allows the zest and oils to seep in as it cooks, giving it a bright, citrusy aroma. Finally, finish with a squeeze of fresh lemon juice just before serving to add a vibrant, tangy kick.",
                    UserId = "36998a40-6007-4cea-ac6e-c191880fa9e8"
                },
                new Tip()
                {
                    Id = 2,
                    ImageUrl = "https://eggs.ca/wp-content/uploads/2024/06/cupcake-with-sprinkles-1664x832-1.jpg",
                    Title = "The Secret to Perfect Cupcakes Every Time",
                    Description = "Want to bake cupcakes that are fluffy, moist, and perfectly domed? Here's a simple tip: start with room-temperature ingredients. Let your eggs, butter, and milk sit out for about 30 minutes before mixing. This ensures the batter blends smoothly, creating a light and even texture.\r\n\r\nAnother key is not to overmix your batter—stop as soon as the ingredients are combined. Overmixing can make your cupcakes dense and tough. For beautifully domed tops, fill your liners about two-thirds full and bake at a slightly higher temperature (around 375°F) for the first 5 minutes, then reduce to 350°F to finish baking.",
                    UserId = "36998a40-6007-4cea-ac6e-c191880fa9e8"
                }
            };

            return tips;
        }
    }
}

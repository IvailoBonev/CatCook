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
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.HasData(CreateRecipes());
        }

        private List<Recipe> CreateRecipes()
        {
            var recipes = new List<Recipe>()
            {
                new Recipe()
                {
                    Id = 1,
                    Name = "Classic Caesar Salad",
                    Descipriton = "A Caesar salad is a timeless dish known for its crisp romaine, creamy dressing, and bold flavors. Here’s how to make it step-by-step:\r\n\r\n    Prepare the Croutons: Preheat your oven to 375°F. Cut a baguette or bread into small cubes, toss with olive oil, garlic powder, and a pinch of salt, then bake for 10-15 minutes until golden and crispy.\r\n\r\n    Make the Dressing: In a bowl, whisk together 1 minced garlic clove, 2 anchovy fillets (mashed), 1 teaspoon Dijon mustard, 1 tablespoon fresh lemon juice, and 1 teaspoon Worcestershire sauce. Slowly whisk in ½ cup olive oil until emulsified. Stir in ½ cup grated Parmesan cheese for a creamy texture. Adjust seasoning with salt and pepper to taste.\r\n\r\n    Assemble the Salad: Wash and dry fresh romaine lettuce, then tear it into bite-sized pieces. Toss the lettuce with the dressing until evenly coated.\r\n\r\n    Add Toppings: Top with the homemade croutons and more grated Parmesan cheese for a finishing touch.\r\n\r\nServe immediately for the best texture and flavor. This classic Caesar salad pairs wonderfully with grilled chicken, shrimp, or as a standalone starter. Enjoy your fresh and flavorful creation!",
                    DifficultyId = 2,
                    CategoryId = 2,
                    Products = new List<string>()
                    {
                        "1 minced garlic clove",
                        "2 anchovy fillets (mashed)",
                        "1 teaspoon Dijon mustard",
                        "1 tablespoon fresh lemon juice",
                        "1 teaspoon Worcestershire sauce",
                        "½ cup olive oil",
                        "½ cup grated Parmesan cheese"
                    },
                    TimeForPreparation = 10,
                    TimeForCooking = 15,
                    PortionsCount = 2,
                    Rating = 4.6,
                    IsPrivate = false,
                    UserId = "36998a40-6007-4cea-ac6e-c191880fa9e8",
                    DateAdded = DateTime.Now
                },
                new Recipe()
                {
                    Id = 2,
                    Name = "Classic Cheesecake",
                    Descipriton = "Making a creamy, decadent cheesecake at home is easier than you think. Here’s a step-by-step guide to create the perfect cheesecake:\r\n\r\n    Prepare the Crust: Preheat your oven to 325°F. In a food processor, pulse 1 ½ cups of graham crackers with ¼ cup of sugar and ½ teaspoon of cinnamon. Add 6 tablespoons of melted butter and mix until combined. Press the mixture into the bottom of a greased 9-inch springform pan. Bake for 10 minutes, then set aside to cool.\r\n\r\n    Make the Filling: In a large mixing bowl, beat 4 packages (32 ounces) of cream cheese at room temperature until smooth. Add 1 cup of granulated sugar and beat until combined. Add 1 teaspoon of vanilla extract and 4 large eggs, one at a time, mixing well after each addition. Finally, blend in 1 cup of sour cream for richness.\r\n\r\n    Bake the Cheesecake: Pour the cream cheese mixture onto the cooled crust. Bake at 325°F for 55-60 minutes, or until the center is just set. Let it cool in the oven with the door slightly ajar for 1 hour, then refrigerate for at least 4 hours.\r\n\r\n    Serve: Top with fresh fruit, fruit compote, or a drizzle of caramel for extra flavor. Enjoy your homemade cheesecake!",
                    DifficultyId = 1,
                    CategoryId = 3,
                    Products = new List<string>()
                    {
                        "1 ½ cups of graham crackers",
                        "¼ cup of sugar",
                        "½ teaspoon of cinnamon",
                        "6 tablespoons of melted butter",
                        "4 packages of cream cheese",
                        "1 cup of granulated sugar",
                        "1 teaspoon of vanilla extract",
                        "4 large eggs",
                        "1 cup of sour cream"
                    },
                    TimeForPreparation = 20,
                    TimeForCooking = 60,
                    Rating = 4.1,
                    IsPrivate = false,
                    UserId = "36998a40-6007-4cea-ac6e-c191880fa9e8",
                    DateAdded = DateTime.Now
                }
            };

            return recipes;
        }
    }
}

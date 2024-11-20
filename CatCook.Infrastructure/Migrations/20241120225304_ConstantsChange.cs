using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ConstantsChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tips",
                type: "nvarchar(1200)",
                maxLength: 1200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "Descipriton",
                table: "Recipes",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                comment: "A description of the recipe",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldComment: "A description of the recipe");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Forums",
                type: "nvarchar(1200)",
                maxLength: 1200,
                nullable: false,
                comment: "The content of the forum",
                oldClrType: typeof(string),
                oldType: "nvarchar(600)",
                oldMaxLength: 600,
                oldComment: "The content of the forum");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comments",
                type: "nvarchar(900)",
                maxLength: 900,
                nullable: false,
                comment: "The comment content",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldComment: "The comment content");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tips",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1200)",
                oldMaxLength: 1200);

            migrationBuilder.AlterColumn<string>(
                name: "Descipriton",
                table: "Recipes",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                comment: "A description of the recipe",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldComment: "A description of the recipe");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Forums",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: false,
                comment: "The content of the forum",
                oldClrType: typeof(string),
                oldType: "nvarchar(1200)",
                oldMaxLength: 1200,
                oldComment: "The content of the forum");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comments",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                comment: "The comment content",
                oldClrType: typeof(string),
                oldType: "nvarchar(900)",
                oldMaxLength: 900,
                oldComment: "The comment content");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApplicationUserId", "AvatarImageUrl", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsPrivate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Points", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0464d803-7820-4ec4-bb42-d75b5a1fcb7c", 0, null, null, "Sofia", "572183c0-d0b7-4b97-96ce-d80960172312", "guest@mail.com", false, "Guest", true, "User", false, null, "guest@mail.com", "guest@mail.com", "AQAAAAIAAYagAAAAEHe6nqB+wFz8mcG21s9DC14fejbodew5HO8UaCnL2TSvHu7xaWpiVjZcn9xQi8V9cw==", null, false, 0, null, null, false, "guest@mail.com" },
                    { "36998a40-6007-4cea-ac6e-c191880fa9e8", 0, null, null, "Burgas", "accf8e61-e449-4bc7-938b-6571453eacb4", "ivan.georgiev@example.com", false, "Ivan", false, "Georgiev", false, null, "ivan.georgiev@example.com", "ivan.georgiev@example.com", "AQAAAAIAAYagAAAAEL9QTfQDss1KRLLaGmYEYXc2wLCZ7KiQ1FnGljtlnXYHCVlUZivA8rgYM44Agztr2Q==", null, false, 0, null, null, false, "ivan.georgiev@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Предястия" },
                    { 2, "Салати" },
                    { 3, "Торти" },
                    { 4, "Риба" },
                    { 5, "Сладкиши" }
                });

            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Лесно" },
                    { 2, "Средно" },
                    { 3, "Трудно" },
                    { 4, "Много трудно" }
                });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "Text", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Hi everyone! I'm trying to make a classic Caesar salad at home, but I’m struggling with the dressing. My main issue is getting the right balance of flavors—it’s either too tangy or too mild. I’m using anchovies, garlic, Dijon mustard, olive oil, lemon juice, and Parmesan, but something feels off. Should I adjust the ratios, or am I missing a key ingredient? Also, any tips for getting the texture just right? Thanks in advance!", "Need Help Perfecting My Caesar Salad Dressing!", "36998a40-6007-4cea-ac6e-c191880fa9e8" },
                    { 2, "Hey yall! I’m trying to make a classic cheesecake, but I’m running into a few issues. My main problem is getting the texture right—it’s either too dense or ends up cracking on top. I’m using cream cheese, eggs, sugar, and a graham cracker crust. Should I adjust baking time or temperature? Also, do I need to use a water bath, or is there another trick to keep it smooth? Any advice would be greatly appreciated. Thanks!", "Help Needed with Cheesecake Recipe!", "36998a40-6007-4cea-ac6e-c191880fa9e8" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "ImageUrl", "RecipeId", "UserId" },
                values: new object[,]
                {
                    { 1, "https://feelgoodfoodie.net/wp-content/uploads/2020/04/Caesar-Salad-TIMG.jpg", null, "36998a40-6007-4cea-ac6e-c191880fa9e8" },
                    { 2, "https://cakesbymk.com/wp-content/uploads/2023/11/Template-Size-for-Blog-Photos-24.jpg", null, "36998a40-6007-4cea-ac6e-c191880fa9e8" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "Descipriton", "DifficultyId", "IsPrivate", "Name", "PortionsCount", "Products", "Rating", "TimeForCooking", "TimeForPreparation", "UserId" },
                values: new object[,]
                {
                    { 1, 2, "A Caesar salad is a timeless dish known for its crisp romaine, creamy dressing, and bold flavors. Here’s how to make it step-by-step:\r\n\r\n    Prepare the Croutons: Preheat your oven to 375°F. Cut a baguette or bread into small cubes, toss with olive oil, garlic powder, and a pinch of salt, then bake for 10-15 minutes until golden and crispy.\r\n\r\n    Make the Dressing: In a bowl, whisk together 1 minced garlic clove, 2 anchovy fillets (mashed), 1 teaspoon Dijon mustard, 1 tablespoon fresh lemon juice, and 1 teaspoon Worcestershire sauce. Slowly whisk in ½ cup olive oil until emulsified. Stir in ½ cup grated Parmesan cheese for a creamy texture. Adjust seasoning with salt and pepper to taste.\r\n\r\n    Assemble the Salad: Wash and dry fresh romaine lettuce, then tear it into bite-sized pieces. Toss the lettuce with the dressing until evenly coated.\r\n\r\n    Add Toppings: Top with the homemade croutons and more grated Parmesan cheese for a finishing touch.\r\n\r\nServe immediately for the best texture and flavor. This classic Caesar salad pairs wonderfully with grilled chicken, shrimp, or as a standalone starter. Enjoy your fresh and flavorful creation!", 2, false, "Classic Caesar Salad", 2, "[\"1 minced garlic clove\",\"2 anchovy fillets (mashed)\",\"1 teaspoon Dijon mustard\",\"1 tablespoon fresh lemon juice\",\"1 teaspoon Worcestershire sauce\",\"\\u00BD cup olive oil\",\"\\u00BD cup grated Parmesan cheese\"]", 4.5999999999999996, 15, 10, "36998a40-6007-4cea-ac6e-c191880fa9e8" },
                    { 2, 3, "Making a creamy, decadent cheesecake at home is easier than you think. Here’s a step-by-step guide to create the perfect cheesecake:\r\n\r\n    Prepare the Crust: Preheat your oven to 325°F. In a food processor, pulse 1 ½ cups of graham crackers with ¼ cup of sugar and ½ teaspoon of cinnamon. Add 6 tablespoons of melted butter and mix until combined. Press the mixture into the bottom of a greased 9-inch springform pan. Bake for 10 minutes, then set aside to cool.\r\n\r\n    Make the Filling: In a large mixing bowl, beat 4 packages (32 ounces) of cream cheese at room temperature until smooth. Add 1 cup of granulated sugar and beat until combined. Add 1 teaspoon of vanilla extract and 4 large eggs, one at a time, mixing well after each addition. Finally, blend in 1 cup of sour cream for richness.\r\n\r\n    Bake the Cheesecake: Pour the cream cheese mixture onto the cooled crust. Bake at 325°F for 55-60 minutes, or until the center is just set. Let it cool in the oven with the door slightly ajar for 1 hour, then refrigerate for at least 4 hours.\r\n\r\n    Serve: Top with fresh fruit, fruit compote, or a drizzle of caramel for extra flavor. Enjoy your homemade cheesecake!", 1, false, "Classic Cheesecake", 0, "[\"1 \\u00BD cups of graham crackers\",\"\\u00BC cup of sugar\",\"\\u00BD teaspoon of cinnamon\",\"6 tablespoons of melted butter\",\"4 packages of cream cheese\",\"1 cup of granulated sugar\",\"1 teaspoon of vanilla extract\",\"4 large eggs\",\"1 cup of sour cream\"]", 4.0999999999999996, 60, 20, "36998a40-6007-4cea-ac6e-c191880fa9e8" }
                });

            migrationBuilder.InsertData(
                table: "Tips",
                columns: new[] { "Id", "Description", "ImageUrl", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "When cooking fish, lemons can be a game-changer for flavor! A great tip is to use lemon in layers throughout your cooking process. Start by marinating your fish with a mixture of lemon juice, olive oil, and your favorite herbs—this not only enhances the flavor but also tenderizes the fish.\r\n\r\nDuring cooking, add thin slices of lemon directly on top of the fish. This allows the zest and oils to seep in as it cooks, giving it a bright, citrusy aroma. Finally, finish with a squeeze of fresh lemon juice just before serving to add a vibrant, tangy kick.", "https://cdn.ruled.me/wp-content/uploads/2017/11/zingy-lemon-fish-featured.jpg", "Elevate Your Fish Dishes with Lemon: A Simple Tip", "36998a40-6007-4cea-ac6e-c191880fa9e8" },
                    { 2, "Want to bake cupcakes that are fluffy, moist, and perfectly domed? Here's a simple tip: start with room-temperature ingredients. Let your eggs, butter, and milk sit out for about 30 minutes before mixing. This ensures the batter blends smoothly, creating a light and even texture.\r\n\r\nAnother key is not to overmix your batter—stop as soon as the ingredients are combined. Overmixing can make your cupcakes dense and tough. For beautifully domed tops, fill your liners about two-thirds full and bake at a slightly higher temperature (around 375°F) for the first 5 minutes, then reduce to 350°F to finish baking.", "https://eggs.ca/wp-content/uploads/2024/06/cupcake-with-sprinkles-1664x832-1.jpg", "The Secret to Perfect Cupcakes Every Time", "36998a40-6007-4cea-ac6e-c191880fa9e8" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ForumId", "Text", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "You might want to add a dash of Worcestershire sauce—it enhances the umami without overpowering. For balance, try adjusting the lemon juice and Parmesan quantities. Also, emulsifying the dressing with a blender can help achieve a smooth, creamy texture. Let us know how it turns out!", "Try Adding Worcestershire Sauce", "0464d803-7820-4ec4-bb42-d75b5a1fcb7c" },
                    { 2, 2, "Using a water bath can really help with preventing cracks and keeping the texture smooth. Wrap your springform pan in foil to avoid leaks, and bake it in a roasting pan with hot water. Also, don’t overmix the batter, as that can introduce air bubbles. Good luck with your cheesecake!", "Might have a solution", "0464d803-7820-4ec4-bb42-d75b5a1fcb7c" }
                });
        }
    }
}

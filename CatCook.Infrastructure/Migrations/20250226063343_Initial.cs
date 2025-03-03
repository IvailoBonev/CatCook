using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false, comment: "The user's first name"),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, comment: "The user's last name"),
                    ProfileName = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false, comment: "The user's profile name"),
                    Points = table.Column<int>(type: "int", nullable: false, comment: "How many cooking points does the user have"),
                    City = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true, comment: "The city of the user"),
                    AvatarImageUrl = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true, comment: "The user avatar image"),
                    Status = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: true, comment: "The user's status for today"),
                    IsWhiteMode = table.Column<bool>(type: "bit", nullable: false, comment: "Does the user prefer white mode?"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Category identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, comment: "Category name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Difficulties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Difficulty identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "The name of the difficulty")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Difficulties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Forums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Forum identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "The title of the forum"),
                    Text = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false, comment: "The content of the forum"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Is the forum deleted (soft delete)"),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forums_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Is the tip deleted (soft delete)"),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tips_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Recipe identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false, comment: "Is the recipe private or public"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Is the recipe deleted (soft delete)"),
                    Name = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false, comment: "The recipe name"),
                    Descipriton = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "A description of the recipe"),
                    DifficultyId = table.Column<int>(type: "int", nullable: false),
                    TimeForPreparation = table.Column<int>(type: "int", nullable: false, comment: "Time needed for preparation for cooking"),
                    TimeForCooking = table.Column<int>(type: "int", nullable: false, comment: "Time needed for cooking"),
                    Rating = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: false, comment: "The ratings of the recipe by users"),
                    PortionsCount = table.Column<int>(type: "int", nullable: false, comment: "How many portions the recipe provides"),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Images used for the recipe")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recipes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recipes_Difficulties_DifficultyId",
                        column: x => x.DifficultyId,
                        principalTable: "Difficulties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Comment identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Title of comment"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Is the comment deleted (soft delete)"),
                    Text = table.Column<string>(type: "nvarchar(1400)", maxLength: 1400, nullable: false, comment: "The comment content"),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ForumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Forums_ForumId",
                        column: x => x.ForumId,
                        principalTable: "Forums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f31e3608-0a53-439a-9cc7-1a0daf4b3119", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarImageUrl", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsWhiteMode", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Points", "ProfileName", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0464d803-7820-4ec4-bb42-d75b5a1fcb7c", 0, null, "Sofia", "61a2aee3-b7e8-4a09-ad19-3c17ecd898d1", "guest@mail.com", false, "Guest", false, "User", false, null, "guest@mail.com", "guest@mail.com", "AQAAAAIAAYagAAAAEIQp59AnSWBDZ0lDTIzXVuMhAY427cC80GpoO5A7OjgsqKGkgkx5XiUqcVK/rHopzQ==", null, false, 0, "Guest", "9f1255aa-eb37-4b55-a71e-593aadf21485", null, false, "guest@mail.com" },
                    { "36998a40-6007-4cea-ac6e-c191880fa9e8", 0, null, "Burgas", "fda642b2-5b78-4162-bdb1-715626d5bf8d", "ivan.georgiev@example.com", false, "Ivan", false, "Georgiev", false, null, "ivan.georgiev@example.com", "ivan.georgiev@example.com", "AQAAAAIAAYagAAAAEPnGzqGA/fs4bzFp42wubEGJDv2IWrHIwTIZfBQFPMWhUe2XsLxKoEiOeopn8cQUDg==", null, false, 0, "Ivan_G", "7e12d69b-6a45-4177-b039-ef67f9aac646", null, false, "ivan.georgiev@example.com" },
                    { "bb7a3df5-42fc-4458-be02-ebc18a9ca65c", 0, null, "Unknown", "40cdbe0f-065b-4bdc-a785-1449f63181cc", "admin@example.com", false, "The", false, "Admin", false, null, "admin@example.com", "admin@example.com", "AQAAAAIAAYagAAAAEKHTvKkYjmQxUxjizi+Ri6x16G6YP75JZY+XV3N0SrD8K9WbkLCmbIT/nY5UWwcOgA==", null, false, 0, "Admin", "f4b0c410-8220-4064-a962-33e774d63ef1", null, false, "admin@example.com" }
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
                    { 5, "Сладкиши" },
                    { 6, "Основно" }
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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f31e3608-0a53-439a-9cc7-1a0daf4b3119", "bb7a3df5-42fc-4458-be02-ebc18a9ca65c" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DateAdded", "IsDeleted", "Text", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 26, 8, 33, 42, 912, DateTimeKind.Local).AddTicks(7834), false, "Hi everyone! I'm trying to make a classic Caesar salad at home, but I’m struggling with the dressing. My main issue is getting the right balance of flavors—it’s either too tangy or too mild. I’m using anchovies, garlic, Dijon mustard, olive oil, lemon juice, and Parmesan, but something feels off. Should I adjust the ratios, or am I missing a key ingredient? Also, any tips for getting the texture just right? Thanks in advance!", "Need Help Perfecting My Caesar Salad Dressing!", "36998a40-6007-4cea-ac6e-c191880fa9e8" },
                    { 2, new DateTime(2025, 2, 26, 8, 33, 42, 912, DateTimeKind.Local).AddTicks(8294), false, "Hey yall! I’m trying to make a classic cheesecake, but I’m running into a few issues. My main problem is getting the texture right—it’s either too dense or ends up cracking on top. I’m using cream cheese, eggs, sugar, and a graham cracker crust. Should I adjust baking time or temperature? Also, do I need to use a water bath, or is there another trick to keep it smooth? Any advice would be greatly appreciated. Thanks!", "Help Needed with Cheesecake Recipe!", "36998a40-6007-4cea-ac6e-c191880fa9e8" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "DateAdded", "Descipriton", "DifficultyId", "ImageUrl", "IsDeleted", "IsPrivate", "Name", "PortionsCount", "Rating", "TimeForCooking", "TimeForPreparation", "UserId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2025, 2, 26, 8, 33, 42, 908, DateTimeKind.Local).AddTicks(4058), "A Caesar salad is a timeless dish known for its crisp romaine, creamy dressing, and bold flavors. Here’s how to make it step-by-step:\r\n\r\n    Prepare the Croutons: Preheat your oven to 375°F. Cut a baguette or bread into small cubes, toss with olive oil, garlic powder, and a pinch of salt, then bake for 10-15 minutes until golden and crispy.\r\n\r\n    Make the Dressing: In a bowl, whisk together 1 minced garlic clove, 2 anchovy fillets (mashed), 1 teaspoon Dijon mustard, 1 tablespoon fresh lemon juice, and 1 teaspoon Worcestershire sauce. Slowly whisk in ½ cup olive oil until emulsified. Stir in ½ cup grated Parmesan cheese for a creamy texture. Adjust seasoning with salt and pepper to taste.\r\n\r\n    Assemble the Salad: Wash and dry fresh romaine lettuce, then tear it into bite-sized pieces. Toss the lettuce with the dressing until evenly coated.\r\n\r\n    Add Toppings: Top with the homemade croutons and more grated Parmesan cheese for a finishing touch.\r\n\r\nServe immediately for the best texture and flavor. This classic Caesar salad pairs wonderfully with grilled chicken, shrimp, or as a standalone starter. Enjoy your fresh and flavorful creation!", 2, "https://natashaskitchen.com/wp-content/uploads/2019/01/Caesar-Salad-Recipe-3.jpg", false, false, "Classic Caesar Salad", 2, 4.5, 15, 10, "36998a40-6007-4cea-ac6e-c191880fa9e8" },
                    { 2, 3, new DateTime(2025, 2, 26, 8, 33, 42, 910, DateTimeKind.Local).AddTicks(7129), "Making a creamy, decadent cheesecake at home is easier than you think. Here’s a step-by-step guide to create the perfect cheesecake:\r\n\r\n    Prepare the Crust: Preheat your oven to 325°F. In a food processor, pulse 1 ½ cups of graham crackers with ¼ cup of sugar and ½ teaspoon of cinnamon. Add 6 tablespoons of melted butter and mix until combined. Press the mixture into the bottom of a greased 9-inch springform pan. Bake for 10 minutes, then set aside to cool.\r\n\r\n    Make the Filling: In a large mixing bowl, beat 4 packages (32 ounces) of cream cheese at room temperature until smooth. Add 1 cup of granulated sugar and beat until combined. Add 1 teaspoon of vanilla extract and 4 large eggs, one at a time, mixing well after each addition. Finally, blend in 1 cup of sour cream for richness.\r\n\r\n    Bake the Cheesecake: Pour the cream cheese mixture onto the cooled crust. Bake at 325°F for 55-60 minutes, or until the center is just set. Let it cool in the oven with the door slightly ajar for 1 hour, then refrigerate for at least 4 hours.\r\n\r\n    Serve: Top with fresh fruit, fruit compote, or a drizzle of caramel for extra flavor. Enjoy your homemade cheesecake!", 1, "https://cakesbymk.com/wp-content/uploads/2023/11/Template-Size-for-Blog-Photos-24.jpg", false, false, "Classic Cheesecake", 3, 4.7000000000000002, 60, 20, "36998a40-6007-4cea-ac6e-c191880fa9e8" }
                });

            migrationBuilder.InsertData(
                table: "Tips",
                columns: new[] { "Id", "DateAdded", "Description", "IsDeleted", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 26, 8, 33, 42, 911, DateTimeKind.Local).AddTicks(1301), "When cooking fish, lemons can be a game-changer for flavor! A great tip is to use lemon in layers throughout your cooking process. Start by marinating your fish with a mixture of lemon juice, olive oil, and your favorite herbs—this not only enhances the flavor but also tenderizes the fish.\r\n\r\nDuring cooking, add thin slices of lemon directly on top of the fish. This allows the zest and oils to seep in as it cooks, giving it a bright, citrusy aroma. Finally, finish with a squeeze of fresh lemon juice just before serving to add a vibrant, tangy kick.", false, "Elevate Your Fish Dishes with Lemon: A Simple Tip", "36998a40-6007-4cea-ac6e-c191880fa9e8" },
                    { 2, new DateTime(2025, 2, 26, 8, 33, 42, 911, DateTimeKind.Local).AddTicks(1562), "Want to bake cupcakes that are fluffy, moist, and perfectly domed? Here's a simple tip: start with room-temperature ingredients. Let your eggs, butter, and milk sit out for about 30 minutes before mixing. This ensures the batter blends smoothly, creating a light and even texture.\r\n\r\nAnother key is not to overmix your batter—stop as soon as the ingredients are combined. Overmixing can make your cupcakes dense and tough. For beautifully domed tops, fill your liners about two-thirds full and bake at a slightly higher temperature (around 375°F) for the first 5 minutes, then reduce to 350°F to finish baking.", false, "The Secret to Perfect Cupcakes Every Time", "36998a40-6007-4cea-ac6e-c191880fa9e8" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "DateAdded", "ForumId", "IsDeleted", "Text", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 26, 8, 33, 42, 912, DateTimeKind.Local).AddTicks(3638), 1, false, "You might want to add a dash of Worcestershire sauce—it enhances the umami without overpowering. For balance, try adjusting the lemon juice and Parmesan quantities. Also, emulsifying the dressing with a blender can help achieve a smooth, creamy texture. Let us know how it turns out!", "Try Adding Worcestershire Sauce", "0464d803-7820-4ec4-bb42-d75b5a1fcb7c" },
                    { 2, new DateTime(2025, 2, 26, 8, 33, 42, 912, DateTimeKind.Local).AddTicks(3932), 2, false, "Using a water bath can really help with preventing cracks and keeping the texture smooth. Wrap your springform pan in foil to avoid leaks, and bake it in a roasting pan with hot water. Also, don’t overmix the batter, as that can introduce air bubbles. Good luck with your cheesecake!", "Might have a solution", "0464d803-7820-4ec4-bb42-d75b5a1fcb7c" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ForumId",
                table: "Comments",
                column: "ForumId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_UserId",
                table: "Forums",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_DifficultyId",
                table: "Recipes",
                column: "DifficultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tips_UserId",
                table: "Tips",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Tips");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Forums");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Difficulties");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

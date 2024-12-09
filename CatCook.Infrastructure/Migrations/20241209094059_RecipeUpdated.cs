using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RecipeUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Products",
                table: "Recipes");

            migrationBuilder.AlterColumn<string>(
                name: "Descipriton",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                comment: "A description of the recipe",
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldComment: "A description of the recipe");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Images used for the recipe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff9cbbc5-52aa-4d45-8fc4-291a90756031", "AQAAAAIAAYagAAAAEEbrcemFLlKjYH5uKoocZoLvdlLzhJxLL6kzqOqJfVIburO3vqDwDFhNLWaEhJhWWg==", "df376b04-21a9-4af6-a011-902035f2f612" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d3a9403-2eb0-4f08-b8ad-68d48270e381", "AQAAAAIAAYagAAAAEIZvKnCaEPeTh2dxinyZpzCbur2JUbiafPQa2TZfjQHYEqggjrBV46TqZGTQGWTP/w==", "0f22381e-db0a-4571-87a3-9f68848b38a9" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2024, 12, 9, 11, 40, 56, 977, DateTimeKind.Local).AddTicks(2822), "https://natashaskitchen.com/wp-content/uploads/2019/01/Caesar-Salad-Recipe-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2024, 12, 9, 11, 40, 56, 977, DateTimeKind.Local).AddTicks(2899), "https://natashaskitchen.com/wp-content/uploads/2019/01/Caesar-Salad-Recipe-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 9, 11, 40, 56, 977, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 9, 11, 40, 56, 977, DateTimeKind.Local).AddTicks(3673));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Recipes");

            migrationBuilder.AlterColumn<string>(
                name: "Descipriton",
                table: "Recipes",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                comment: "A description of the recipe",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "A description of the recipe");

            migrationBuilder.AddColumn<string>(
                name: "Products",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Products used for the recipe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a413247e-0ddc-42aa-aa9d-549695e00ef2", "AQAAAAIAAYagAAAAEFKQ22iL9xd+kDoej+N/VoIuTDF7WA8N7IDUx9QoI+KR7CH0UUutRl22i0hqIMhgIQ==", "95ec1405-a251-4433-b768-ad5fd0738cd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0eca05b8-e242-4e8b-b5c3-c2b70435a4d2", "AQAAAAIAAYagAAAAENeNh9fxVzdfNJfpm9RR/WwxkWhaRpK+PHNwjyF/5rzD0ubyl3j4MPiu6JCplc374Q==", "18f9b5b9-4e22-49d4-bf9e-b6df23df0993" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Products" },
                values: new object[] { new DateTime(2024, 12, 7, 17, 22, 37, 439, DateTimeKind.Local).AddTicks(9696), "[\"1 minced garlic clove\",\"2 anchovy fillets (mashed)\",\"1 teaspoon Dijon mustard\",\"1 tablespoon fresh lemon juice\",\"1 teaspoon Worcestershire sauce\",\"\\u00BD cup olive oil\",\"\\u00BD cup grated Parmesan cheese\"]" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Products" },
                values: new object[] { new DateTime(2024, 12, 7, 17, 22, 37, 439, DateTimeKind.Local).AddTicks(9736), "[\"1 \\u00BD cups of graham crackers\",\"\\u00BC cup of sugar\",\"\\u00BD teaspoon of cinnamon\",\"6 tablespoons of melted butter\",\"4 packages of cream cheese\",\"1 cup of granulated sugar\",\"1 teaspoon of vanilla extract\",\"4 large eggs\",\"1 cup of sour cream\"]" });

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 7, 17, 22, 37, 439, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 7, 17, 22, 37, 439, DateTimeKind.Local).AddTicks(9861));
        }
    }
}

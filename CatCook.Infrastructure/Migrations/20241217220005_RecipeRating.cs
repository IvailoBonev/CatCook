using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RecipeRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Recipes",
                type: "float",
                nullable: false,
                comment: "The ratings of the recipe by users",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The ratings of the recipe by users");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50b361f4-2c7c-43a7-9d87-8eac70e0951c", "AQAAAAIAAYagAAAAEOdQHn+Rg77iH7g0t6cD8oyjkXcLMGGOt61ftw1KAdg/3vFvf6DzmQd9yqZ9I+/wqg==", "16b23c3e-724b-471c-8112-059c39e9fe3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8198dcee-3021-4252-b02e-2a937d4db942", "AQAAAAIAAYagAAAAEKmO+yXRrBy60jvrh8nm6k3nfRBUXMjLlNnerey8HWzNMTIZibPpBWeNjB5W5l9aeA==", "786d5fe9-6e77-41c7-b15e-278696b77c1c" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 0, 4, 734, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 0, 4, 734, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 0, 4, 734, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 0, 4, 734, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Rating" },
                values: new object[] { new DateTime(2024, 12, 18, 0, 0, 4, 730, DateTimeKind.Local).AddTicks(135), 4.4666666666666668 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Rating" },
                values: new object[] { new DateTime(2024, 12, 18, 0, 0, 4, 732, DateTimeKind.Local).AddTicks(7291), 4.4333333333333336 });

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 0, 4, 733, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 0, 4, 733, DateTimeKind.Local).AddTicks(2319));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                comment: "The ratings of the recipe by users",
                oldClrType: typeof(double),
                oldType: "float",
                oldComment: "The ratings of the recipe by users");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f49465a3-ee83-42a5-ad57-31beb6e63ba2", "AQAAAAIAAYagAAAAELQZyR/hFetlqntFm1tFz120WoEKQqzpl2g3j1iZaPr32Ll88J+JkLHbzYlwMEx3kw==", "91e7a5c3-6186-42a1-8da2-e8e0979dd54d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42cd738e-afcf-4e50-936c-5750ab2913b2", "AQAAAAIAAYagAAAAECq2lGDSZ4yaIQ9Jyp2ZEnynkcSs0DcTUddRqd/2UrePI7F4ntzdcRLEz2aOZm67/A==", "76542c2e-c0cd-457c-a95e-490fac340ee9" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 23, 9, 44, 555, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 23, 9, 44, 555, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 23, 9, 44, 555, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 23, 9, 44, 555, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Rating" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 9, 44, 551, DateTimeKind.Local).AddTicks(1711), "[4.9,4,4.5]" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Rating" },
                values: new object[] { new DateTime(2024, 12, 17, 23, 9, 44, 553, DateTimeKind.Local).AddTicks(6201), "[4.8,4.2,4.3]" });

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 23, 9, 44, 554, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 23, 9, 44, 554, DateTimeKind.Local).AddTicks(605));
        }
    }
}

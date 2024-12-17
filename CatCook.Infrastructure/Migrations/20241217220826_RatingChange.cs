using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RatingChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Recipes",
                type: "float(18)",
                precision: 18,
                scale: 2,
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
                values: new object[] { "b7f0a2ba-f34b-4f99-a191-399fa1c24bfb", "AQAAAAIAAYagAAAAEKnBflJShd/g2vfOmFVGvaw5+inWxNALC1xIy0EYQ76D/TGvImDz4607kmhfLQ5hmg==", "f9af9442-e1d6-4cbf-8f46-5938d7ca4167" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1e0c265-d738-4198-9000-9d9e0a88936a", "AQAAAAIAAYagAAAAEIejE7q9TEhFtCZX0UvkSKbaMyoxtaYmh728OGUVZLkCKCPK9zLv3g0Ft6Bqn8oTBw==", "dfa8d6f2-8d2e-4cb7-b69f-f0a6e230ebe4" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 8, 23, 797, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 8, 23, 797, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 8, 23, 797, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 8, 23, 797, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Rating" },
                values: new object[] { new DateTime(2024, 12, 18, 0, 8, 23, 791, DateTimeKind.Local).AddTicks(5977), 4.5 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Rating" },
                values: new object[] { new DateTime(2024, 12, 18, 0, 8, 23, 794, DateTimeKind.Local).AddTicks(9628), 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 8, 23, 795, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 8, 23, 795, DateTimeKind.Local).AddTicks(4657));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Recipes",
                type: "float",
                nullable: false,
                comment: "The ratings of the recipe by users",
                oldClrType: typeof(double),
                oldType: "float(18)",
                oldPrecision: 18,
                oldScale: 2,
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
    }
}

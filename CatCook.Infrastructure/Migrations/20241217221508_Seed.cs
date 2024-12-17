using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3edc41a-3689-4022-afa9-722be079c3ba", "AQAAAAIAAYagAAAAEIwnJGGawB1s3QFVbTuszjaRZUz95fnQREjdZu3mPNH7T/N5SvADFGyD6/z+sGSusg==", "22450535-0a36-4d37-8cb3-265411165548" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7acca806-700c-4041-ab04-916c07f47b34", "AQAAAAIAAYagAAAAEPEmx5VjFuisLxeyv7/fo5ZhvcI1RYIXNA0cABIzy4IKUMapqHyuywM5r2Gw8d1oVw==", "14e79d07-b43a-4a7b-bab5-aebacb4e78f9" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 15, 7, 418, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 15, 7, 418, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 15, 7, 419, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 15, 7, 419, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 15, 7, 414, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 15, 7, 417, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 15, 7, 417, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 15, 7, 417, DateTimeKind.Local).AddTicks(4838));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "900a6442-e1f0-4c7a-9add-503d04b2d183", "AQAAAAIAAYagAAAAEGqkjcKCj2xnDu9uBuXdOQhYLvTDg0NMXMRDTDyLdhZnJMtXat+IeBlGLNElusSurw==", "081480fb-651b-4107-a272-732149ee8989" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f24c6f5f-62bc-43d7-a46a-2faf6449f1a1", "AQAAAAIAAYagAAAAENMsy9bgOwIKR1segmFTWA+oEZZbdz4SrXPb7XiGRQQYa/64Y37an9OpdxcbqO+VHA==", "a418fc5f-66dd-4053-a68c-5cf402c4b7d3" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 9, 47, 462, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 9, 47, 462, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 9, 47, 463, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 9, 47, 463, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 9, 47, 458, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 9, 47, 461, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 9, 47, 461, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 9, 47, 461, DateTimeKind.Local).AddTicks(7840));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DateAddedForTips : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Tips");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Tips",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7f8cf6d-222e-4946-a68f-2704a72bfcbb", "AQAAAAIAAYagAAAAEKmkqaHw3mGs1lXrmfK6tvJTZx87PMDSz384ecuKal8KhENrANMI2ciIP1MmDyS9rQ==", "06678bed-08d1-4499-b4dd-f1f4d7db26b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7845285-b269-40a8-b38e-eb121fc7fe8a", "AQAAAAIAAYagAAAAEH6oGz/Hkxwxlwu95nSWb9qG+m2ZPXTpu/CeApxbYix3E4PmIojjpiGEM23MSbL8qw==", "1653db78-5f15-4ea5-be5e-806a351306d7" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 4, 22, 0, 38, 81, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 4, 22, 0, 38, 81, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 4, 22, 0, 38, 81, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 4, 22, 0, 38, 81, DateTimeKind.Local).AddTicks(8924));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Tips");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Tips",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccac93a4-752f-4cf9-8c04-7d3ba52d8cad", "AQAAAAIAAYagAAAAEOC0/MUiDWfQ6SakmagPXTl9fSexQdAXVJpDFT/1bb5HK4wq2u4MP1yk0E8L5pLcJQ==", "e87932ec-b632-4314-bc81-2015c9efd953" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e223ec11-5d47-4276-b679-792b39f7d516", "AQAAAAIAAYagAAAAEMvJtJUqGStKGYP32C7tNuGmkx102yTFiXwAK0+Elqoo4iczIwuJtX0UFjq0cv8Y+A==", "9ef5d8df-c15e-4ae3-9e81-070fb2db05c2" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 3, 21, 14, 59, 44, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 3, 21, 14, 59, 52, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://cdn.ruled.me/wp-content/uploads/2017/11/zingy-lemon-fish-featured.jpg");

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://eggs.ca/wp-content/uploads/2024/06/cupcake-with-sprinkles-1664x832-1.jpg");
        }
    }
}

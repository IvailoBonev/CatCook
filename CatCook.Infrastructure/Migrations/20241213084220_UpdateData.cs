using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b39bcb4f-19c8-4177-a850-27946e4280e3", "AQAAAAIAAYagAAAAEM2tqVgmQs8Whd+/8xvdJMh+WHi9eVOqCLM/RmQz5EaRHFkgEWBN6KX3OO8iHukAQA==", "52fc2d35-93be-4187-916d-9962ff1f3fc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35fd017b-89a8-48a2-9357-f2978c5919b9", "AQAAAAIAAYagAAAAEFJZRZQncIRY9BqdwMI4x+MI3NFDOS2yhNWvERZbYnCQIUch1yo6HIjqPI2KYcBemA==", "6a5405b6-1ddd-4e91-af42-25c90e9d709c" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 42, 20, 160, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 42, 20, 160, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 42, 20, 160, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 42, 20, 160, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 42, 20, 160, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 42, 20, 160, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 42, 20, 160, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 42, 20, 160, DateTimeKind.Local).AddTicks(2504));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f5cfa57-67ec-4fb1-bb0f-665aa28738d7", "AQAAAAIAAYagAAAAEC324n0AQFC3H9tX7CnC7JQtfh8ZNaothAnPFdSs5hPpfFXMDNTf2jLhbXYOPjNn1w==", "23dba99b-ce64-460b-80e4-43940c4ceb37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17a6add5-4fc6-405d-86e6-aa60fc8da3cc", "AQAAAAIAAYagAAAAEOhhEVp5OJp4/+APZhWy2hjKxEtCuN+o6LszYQogbqqKCEa/jNwHIxhM6g4GJ61KIQ==", "aa5b44aa-9d4b-49b5-b082-982ee63fb575" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 41, 28, 775, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 41, 28, 775, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 41, 28, 775, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 41, 28, 775, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 41, 28, 775, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 41, 28, 775, DateTimeKind.Local).AddTicks(5882));
        }
    }
}

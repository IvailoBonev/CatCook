using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedTitleComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Comments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Title of comment",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldComment: "Title of comment");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comments",
                type: "nvarchar(1400)",
                maxLength: 1400,
                nullable: false,
                comment: "The comment content",
                oldClrType: typeof(string),
                oldType: "nvarchar(900)",
                oldMaxLength: 900,
                oldComment: "The comment content");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08bd2f19-0f53-419f-9a06-0629e8df8483", "AQAAAAIAAYagAAAAEGC16nxe004dx9amSS7sa6HBDmc+gnBNyB1nlIH44vkF1S5C811NfA0XxEMMCxh6dA==", "bce5be81-2c70-4e1d-b066-c19ad470f3a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cd89399-ed86-4972-9cc2-2f95b5099647", "AQAAAAIAAYagAAAAEBDgwhFoQpiLkvje2KwN4fDSDJKYzihVect97iLLUAsOjs4unOWuj1JqWLUUFoGupw==", "ffd0d5c8-cb7b-4e07-a2de-9e5dd5c3dc2a" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 13, 36, 16, 33, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 13, 36, 16, 33, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 13, 36, 16, 33, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 13, 36, 16, 33, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 13, 36, 16, 33, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 13, 36, 16, 33, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 13, 36, 16, 33, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 13, 36, 16, 33, DateTimeKind.Local).AddTicks(3637));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Comments",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                comment: "Title of comment",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Title of comment");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comments",
                type: "nvarchar(900)",
                maxLength: 900,
                nullable: false,
                comment: "The comment content",
                oldClrType: typeof(string),
                oldType: "nvarchar(1400)",
                oldMaxLength: 1400,
                oldComment: "The comment content");

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserImageRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_AspNetUsers_UserId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_UserId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Images");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14c789a0-c1e6-45c7-8d58-ff0dd16ce732", "AQAAAAIAAYagAAAAECO50sTjmWLzuUsf/RSdAaQFp0cC2geLKzN2SmPgT+p9iZU9YUBSRep9C2nZ/UbIog==", "f2612972-fb70-47f0-9e26-5edd3b80031f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20f70f85-b167-4a4a-a069-d38b448b4dec", "AQAAAAIAAYagAAAAENfdYzCo0PZR2u1sRWn3KPv09TujxZHXOSD/I/cgXDh/v7FdIvkn/0wmw4t9udKGnA==", "68fa058a-17c3-4f66-98be-614d22f1117c" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 1, 22, 37, 38, 431, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 1, 22, 37, 38, 431, DateTimeKind.Local).AddTicks(6658));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Images",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc2a512f-9a78-455b-b943-dcd1d2bb14c6", "AQAAAAIAAYagAAAAEIn7S4dWfcjbjXgmMZNXdcLdZ0XkqZrpTuTj9KUDfM31QuSzcPsg8jtvB5Uo+BVVMw==", "10f0765f-68c2-4813-a5e8-3a0d13a1c042" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5124639-8f9a-4153-b2c9-2b013590d61e", "AQAAAAIAAYagAAAAEGxu7Hq6bv88kRLhMR2aMXU51fgew+iJ+66ZBcYI2q7tvBOpn/zOYpWH9r96VaLfdA==", "2c55edf7-5b51-4dbb-803d-dec2da77f417" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "36998a40-6007-4cea-ac6e-c191880fa9e8");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "36998a40-6007-4cea-ac6e-c191880fa9e8");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 1, 22, 24, 50, 650, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 1, 22, 24, 50, 650, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.CreateIndex(
                name: "IX_Images_UserId",
                table: "Images",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_AspNetUsers_UserId",
                table: "Images",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

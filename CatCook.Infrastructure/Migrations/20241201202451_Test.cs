using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bfd00b9-73ae-484d-9c23-e039f641f9ea", "AQAAAAIAAYagAAAAEEP2tqbdXKfUq6Few0tHolK4kLtcD2j2RIw50pmVGPGLNCTcjB8vOBXTVPnS6KYXNg==", "e3ed18f1-660b-4091-be13-037de10b129c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cc1a2ba-624b-4601-afa6-d840de3e9ea9", "AQAAAAIAAYagAAAAEBWdIvHEURR+XDxUsBC8AVyx7zKQ6B3Z3NFdd+lsjQ9JudJJkXYSIi3b3pM1DwAhtw==", "db7b9f74-ba60-499f-8ad2-3ccb322e9be3" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 1, 22, 10, 16, 396, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 1, 22, 10, 16, 396, DateTimeKind.Local).AddTicks(687));
        }
    }
}

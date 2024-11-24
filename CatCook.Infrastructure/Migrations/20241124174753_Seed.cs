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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileName", "SecurityStamp" },
                values: new object[] { "78925ea5-3079-4761-b652-f4c68a3f839b", "AQAAAAIAAYagAAAAEPTZyHQ2+k0wlBkDSJ+GGOd5B8xfCdvdsog2//XvrdILT4aPJTwHoVINxzRmgVDnOQ==", "Guest", "5e0cd98c-e253-4f8a-a2b5-5b697de16d6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileName", "SecurityStamp" },
                values: new object[] { "776aa052-75cb-4109-8a88-220c630223d7", "AQAAAAIAAYagAAAAEFmBDWWYcTuMaNBNmDMXeeTt+xaNANA/tXV2vRpN80S2mNJ59cbwxJS8S/0VZ40cQw==", "Ivan_G", "80a2e8d2-f39a-4fcf-8bd3-45df8270174a" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 11, 24, 19, 47, 53, 39, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 11, 24, 19, 47, 53, 39, DateTimeKind.Local).AddTicks(2229));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileName", "SecurityStamp" },
                values: new object[] { "a6ae2942-9139-467a-8adf-d423fec3126c", "AQAAAAIAAYagAAAAEMY6khi2d0SRqQ/seEcZ+9dIcCaAU2Zf8Dc2ojcc7Lgjbota5pVwOL26wSxlh/B+cg==", "", "0688f479-1c1e-4f40-ba06-f4aef2aa4ae0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileName", "SecurityStamp" },
                values: new object[] { "02ca79a8-98bd-447b-805a-4c66aa6bf1aa", "AQAAAAIAAYagAAAAEEV1klp/uvxavo13a/HvzcQs0Zelcxc5UcoZg9JprEubHSd/Tqo5etOL6NylVTgvkA==", "", "0cbb9773-0f41-412b-8f2b-a1fdd44bcb53" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 11, 24, 19, 36, 3, 799, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 11, 24, 19, 36, 3, 799, DateTimeKind.Local).AddTicks(6359));
        }
    }
}

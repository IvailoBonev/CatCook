using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RatingUpgrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                comment: "The ratings of the recipe by users",
                oldClrType: typeof(double),
                oldType: "float",
                oldComment: "The average rating of the recipe by users");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e0c7bdd-0b63-4901-82be-ced1384e0cb3", "AQAAAAIAAYagAAAAEGr/XIFZA1JHYG4lzea6G7ZSPq6FzKGzaAJV47kiqXaNAwWfHIXFBzs3wRPdPopMBQ==", "03b7fcd1-aa60-48c1-a426-5a3336e2c006" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fefd1a3a-ee9b-47c4-bae5-e91147b52fc9", "AQAAAAIAAYagAAAAEG2Ir7vZMvpSRqiqQ97J7bqocAw2xtMEkRBhbWHoQl+ioerrRPsqM61qErlxSPoD6Q==", "6af6d7c1-6966-4b26-a95b-6740093a5f69" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Rating" },
                values: new object[] { new DateTime(2024, 11, 28, 21, 22, 14, 591, DateTimeKind.Local).AddTicks(7457), "[4.9,4,4.5]" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Rating" },
                values: new object[] { new DateTime(2024, 11, 28, 21, 22, 14, 591, DateTimeKind.Local).AddTicks(7496), "[4.8,4.2,4.3]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Recipes",
                type: "float",
                nullable: false,
                comment: "The average rating of the recipe by users",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The ratings of the recipe by users");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78925ea5-3079-4761-b652-f4c68a3f839b", "AQAAAAIAAYagAAAAEPTZyHQ2+k0wlBkDSJ+GGOd5B8xfCdvdsog2//XvrdILT4aPJTwHoVINxzRmgVDnOQ==", "5e0cd98c-e253-4f8a-a2b5-5b697de16d6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "776aa052-75cb-4109-8a88-220c630223d7", "AQAAAAIAAYagAAAAEFmBDWWYcTuMaNBNmDMXeeTt+xaNANA/tXV2vRpN80S2mNJ59cbwxJS8S/0VZ40cQw==", "80a2e8d2-f39a-4fcf-8bd3-45df8270174a" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Rating" },
                values: new object[] { new DateTime(2024, 11, 24, 19, 47, 53, 39, DateTimeKind.Local).AddTicks(2138), 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Rating" },
                values: new object[] { new DateTime(2024, 11, 24, 19, 47, 53, 39, DateTimeKind.Local).AddTicks(2229), 4.0999999999999996 });
        }
    }
}

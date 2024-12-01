using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Fixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Recipes",
                type: "nvarchar(90)",
                maxLength: 90,
                nullable: false,
                comment: "The recipe name",
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80,
                oldComment: "The recipe name");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Recipes",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                comment: "The recipe name",
                oldClrType: typeof(string),
                oldType: "nvarchar(90)",
                oldMaxLength: 90,
                oldComment: "The recipe name");

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
                column: "DateAdded",
                value: new DateTime(2024, 11, 28, 21, 22, 14, 591, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 11, 28, 21, 22, 14, 591, DateTimeKind.Local).AddTicks(7496));
        }
    }
}

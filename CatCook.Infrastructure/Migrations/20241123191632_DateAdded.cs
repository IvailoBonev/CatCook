using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DateAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Recipes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "795fc472-94e4-4ccc-a27d-8ed712e58aa0", "AQAAAAIAAYagAAAAEMOohjSuoqbC/DmE4huHwUjMlZv76IIx/uzPIZBDbZYmye6z6zwPzOrurvwCibO/Pw==", "9f2f116f-c5d2-45f9-98f2-4abe2c0023b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e6746e2-0278-48be-a6b8-963bef35f6a3", "AQAAAAIAAYagAAAAEA3bdCPC/tsVHKCVqvIlpiK563Gku7lkNqXMhEYd6P2ZbkCEOAHNetwHX60ftK5W3w==", "19e31ee0-52f4-404b-b8f4-ea917b0b6fb5" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 11, 23, 21, 16, 29, 397, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 11, 23, 21, 16, 29, 397, DateTimeKind.Local).AddTicks(2237));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Recipes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "400ca597-c97a-4167-9ce9-21255a545024", "AQAAAAIAAYagAAAAEEpgJaY+EdNSNweCiRdyrCZkmzR/tl//Fs/IiccKkL4IHZ7w0++1zuDqrRQ9qhKGzQ==", "c279d34a-cc09-4226-aecb-b83615e2f83e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbb37740-5fbe-4a71-9158-a5d985f4ffc6", "AQAAAAIAAYagAAAAEALi26rSCvM1BysyKmFgvaI91ud/b1KoUNItBbcGhfe3JG+iqpX6/SCO60AIaUjnJA==", "f6661968-608e-4715-a82e-bab75e617b84" });
        }
    }
}

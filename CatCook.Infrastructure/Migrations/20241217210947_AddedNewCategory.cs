using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f49465a3-ee83-42a5-ad57-31beb6e63ba2", "AQAAAAIAAYagAAAAELQZyR/hFetlqntFm1tFz120WoEKQqzpl2g3j1iZaPr32Ll88J+JkLHbzYlwMEx3kw==", "91e7a5c3-6186-42a1-8da2-e8e0979dd54d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42cd738e-afcf-4e50-936c-5750ab2913b2", "AQAAAAIAAYagAAAAECq2lGDSZ4yaIQ9Jyp2ZEnynkcSs0DcTUddRqd/2UrePI7F4ntzdcRLEz2aOZm67/A==", "76542c2e-c0cd-457c-a95e-490fac340ee9" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Основно" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 23, 9, 44, 555, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 23, 9, 44, 555, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 23, 9, 44, 555, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 23, 9, 44, 555, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 23, 9, 44, 551, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 23, 9, 44, 553, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 23, 9, 44, 554, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 23, 9, 44, 554, DateTimeKind.Local).AddTicks(605));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08ccf705-60f2-4184-a84f-153ec76ab356", "AQAAAAIAAYagAAAAEFRmeckLL3lIEsvZ60oBQSes8AvuZghVx34zg0PyP0dg5ye01a1xp9jS75q433IG1Q==", "38ef8cd3-c385-4d61-9b47-86742627cc7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c63e6547-132d-4862-80ea-f7ba292a30cc", "AQAAAAIAAYagAAAAEOQBhPJ8AEFnvRUadROY0NbLuHLUxrqwNzrXDE9aYzlu/QCSe0r+xppTGCXRDl9DYw==", "eff2fb7c-23f6-4d28-8dc4-745ff5edcf6f" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 21, 31, 29, 540, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 21, 31, 29, 540, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 21, 31, 29, 541, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 21, 31, 29, 541, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 21, 31, 29, 536, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 21, 31, 29, 539, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 21, 31, 29, 539, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 21, 31, 29, 539, DateTimeKind.Local).AddTicks(6932));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemovedFreindsFeature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ApplicationUserId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ApplicationUserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0d3969a-b9ec-4e00-959a-39992c01bf0a", "AQAAAAIAAYagAAAAEOvIe7Ntt4HBdubbFIvBTvABM5GFD24ptxDiOCQdIqczE67SMExEqKso4QNYIEoqIA==", "73f22c7e-3c4a-4c28-a604-eacb05b43397" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f775e1a-438a-40a2-b2af-ded2945cfb95", "AQAAAAIAAYagAAAAEJ8BmQZE2t5/RaqF7IX6IX29zcyjWDDs4RRyickR/2oXUNBjgAjdGJ8EaTuGaunnuA==", "32b4d9ad-8fda-4796-ba14-6b890fd1494e" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 0, 30, 11, 91, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 0, 30, 11, 91, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 0, 30, 11, 91, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 0, 30, 11, 91, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 0, 30, 11, 87, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 0, 30, 11, 89, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 0, 30, 11, 89, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 0, 30, 11, 90, DateTimeKind.Local).AddTicks(3));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ApplicationUserId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "1f5bedbd-441a-4140-8053-fdec25b7e999", "AQAAAAIAAYagAAAAEC/kWpLJT4wkFQEyO8ZchJ9F8Dv04R+zNOCtjS6SEyjdMqVnbg6af1Tp/UuNI71TmA==", "72bd6429-a50d-4a9f-b9a5-a5ad6482c613" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ApplicationUserId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "448d3c49-a207-459b-9b33-0bd6bc77f35e", "AQAAAAIAAYagAAAAEC77nnO7QLFJxdn+PHymFAVTtlIdqyCdjl+w6MhfZjTP4ayoyuGeO0X/ZPQiLEHIcA==", "649b89cf-27c4-4e8a-9e42-1306c513315f" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 23, 47, 9, 974, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 23, 47, 9, 974, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 23, 47, 9, 974, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 23, 47, 9, 974, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 23, 47, 9, 970, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 23, 47, 9, 972, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 23, 47, 9, 973, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 23, 47, 9, 973, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ApplicationUserId",
                table: "AspNetUsers",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ApplicationUserId",
                table: "AspNetUsers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}

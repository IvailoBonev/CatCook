using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class QuickFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa192b4d-0c68-4ff5-916a-1401e20deda1", "AQAAAAIAAYagAAAAEP+us/0elWcJIAox2nqmjo7EpDqDvxN3XUvHVtS7Ttch5xAX3blpST3g1ulJ5183Mg==", "6593bd6c-472a-4945-b62d-95cc18e2c8f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6c9c344-aa0e-45b5-92a5-c71f12638a30", "AQAAAAIAAYagAAAAEFPbvXLYtQ0ratfm6P18SGXtSGpOj/bUOx/NTEMy30YEIu+EKPXFCpCggxAlLcKIvQ==", "e1d1ca4b-351a-49e7-b615-3c967e994a36" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 0, 31, 1, 44, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 0, 31, 1, 44, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 0, 31, 1, 44, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 0, 31, 1, 44, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 0, 31, 1, 40, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 0, 31, 1, 42, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 0, 31, 1, 43, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 0, 31, 1, 43, DateTimeKind.Local).AddTicks(3610));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}

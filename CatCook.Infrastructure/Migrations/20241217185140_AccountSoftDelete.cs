using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AccountSoftDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is the account deleted (soft delete)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "IsDeleted", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1e6c8f3-6c39-4da6-b492-032637584cdf", false, "AQAAAAIAAYagAAAAELOmiUKU5G9m6jitLbgsX2bJG8oVuX7yCN2UC+h85arY26vm0XeYO/PeIsW7L2v/RQ==", "12b5579c-cb99-40a1-a533-22cd6ccb6299" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "IsDeleted", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bf3ade2-783c-4698-8391-5e8f8ad41d6f", false, "AQAAAAIAAYagAAAAEN+fsxwZHMjr93FTk3ycrqoMGYgllrQd7qjt4Oj6KkFtuMjFYVwWS946YKqSu4CIqQ==", "100311af-195a-4f2d-a6e7-40a1bf86d5cf" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 20, 51, 37, 757, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 20, 51, 37, 757, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 20, 51, 37, 758, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 20, 51, 37, 758, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 20, 51, 37, 753, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 20, 51, 37, 756, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 20, 51, 37, 756, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 17, 20, 51, 37, 756, DateTimeKind.Local).AddTicks(8165));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

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
    }
}

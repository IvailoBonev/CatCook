using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemovedUserSoftDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

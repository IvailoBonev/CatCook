using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DateAddedComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Forums",
                type: "nvarchar(1500)",
                maxLength: 1500,
                nullable: false,
                comment: "The content of the forum",
                oldClrType: typeof(string),
                oldType: "nvarchar(1200)",
                oldMaxLength: 1200,
                oldComment: "The content of the forum");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f5cfa57-67ec-4fb1-bb0f-665aa28738d7", "AQAAAAIAAYagAAAAEC324n0AQFC3H9tX7CnC7JQtfh8ZNaothAnPFdSs5hPpfFXMDNTf2jLhbXYOPjNn1w==", "23dba99b-ce64-460b-80e4-43940c4ceb37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17a6add5-4fc6-405d-86e6-aa60fc8da3cc", "AQAAAAIAAYagAAAAEOhhEVp5OJp4/+APZhWy2hjKxEtCuN+o6LszYQogbqqKCEa/jNwHIxhM6g4GJ61KIQ==", "aa5b44aa-9d4b-49b5-b082-982ee63fb575" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 41, 28, 775, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 41, 28, 775, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 41, 28, 775, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 41, 28, 775, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 41, 28, 775, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 13, 10, 41, 28, 775, DateTimeKind.Local).AddTicks(5882));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Forums",
                type: "nvarchar(1200)",
                maxLength: 1200,
                nullable: false,
                comment: "The content of the forum",
                oldClrType: typeof(string),
                oldType: "nvarchar(1500)",
                oldMaxLength: 1500,
                oldComment: "The content of the forum");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c5c6da5-68aa-48c0-aab7-d922ce51ccb9", "AQAAAAIAAYagAAAAEBs+4+mTviB2pVy0uezjv02GuhlqnEfpZHrv3roNRDWzI3WuP5DBkxKQSlMsm/cx8w==", "b4b6ad26-c7b2-482a-bf39-440e1607a523" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ad51cd3-6162-48a4-ba5c-0b1d9db7a7ca", "AQAAAAIAAYagAAAAEH8VWko6q59a13IkkqCjNJCev9NjrwaRYsXvq+hsS7c91OUvj2/9/iMdCkRPPXqA7w==", "21f43b66-edf4-4076-b90a-eed375f5fcf0" });

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 12, 9, 39, 20, 353, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 12, 9, 39, 20, 353, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 12, 9, 39, 20, 353, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 12, 9, 39, 20, 353, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 12, 9, 39, 20, 353, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 12, 9, 39, 20, 353, DateTimeKind.Local).AddTicks(867));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DateAddedForForum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Forums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e98195c8-30f3-419a-a2f3-a0d81efb1e88", "AQAAAAIAAYagAAAAEKe5ZD0QlfTqeZVMxY/RdDMkRsAid75KczvUcMBoa5yy4TftUB4Za9iv2Vz3cxvr4w==", "eec2e182-9bb7-40ad-bda7-dd493debdb6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01825ae4-5e1c-4ae3-9726-df416014551c", "AQAAAAIAAYagAAAAEC2Jq5R1/Xl3hwBRwWZ+mM3F4nPUAaKffz/q7GeJBYUFkcF8qLJKMS6HoHXlI5oxLQ==", "cbf88655-d651-4573-bcd0-87a705992d4b" });

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 12, 9, 36, 29, 907, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 12, 9, 36, 29, 907, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 12, 9, 36, 29, 907, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 12, 9, 36, 29, 907, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 12, 9, 36, 29, 907, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 12, 9, 36, 29, 907, DateTimeKind.Local).AddTicks(5712));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Forums");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "467fe0d6-1edb-40ec-808c-33e41e3caa1d", "AQAAAAIAAYagAAAAEM+0GzQSNXaG0HXYQLrwyDF/o71lkJpT+LoLJ5b/EINM4Zp+oHdVPSNiN//pNX2F4w==", "22eb4332-4c2e-4fe5-9631-ff0f6f6b6dcf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b26f8f0-5e4e-4ddb-9124-a84482fa21c1", "AQAAAAIAAYagAAAAEMLdXNtIA5KTkObnNoETIQ/0Opfxo3DKItEcPxCh4n6kCGA5/2jPsyjSKZFh2OGyxg==", "a9164d75-1028-4d62-9703-cebe0b615fa4" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 9, 22, 34, 23, 544, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 9, 22, 34, 23, 544, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 9, 22, 34, 23, 544, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 9, 22, 34, 23, 544, DateTimeKind.Local).AddTicks(3076));
        }
    }
}

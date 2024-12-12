using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ForumCommentsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "AspNetUsers",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                comment: "The user's status for today",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "The user's status for today");

            migrationBuilder.AlterColumn<string>(
                name: "AvatarImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: true,
                comment: "The user avatar image",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldComment: "The user avatar image");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f5bedbd-441a-4140-8053-fdec25b7e999", "AQAAAAIAAYagAAAAEC/kWpLJT4wkFQEyO8ZchJ9F8Dv04R+zNOCtjS6SEyjdMqVnbg6af1Tp/UuNI71TmA==", "72bd6429-a50d-4a9f-b9a5-a5ad6482c613" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "448d3c49-a207-459b-9b33-0bd6bc77f35e", "AQAAAAIAAYagAAAAEC77nnO7QLFJxdn+PHymFAVTtlIdqyCdjl+w6MhfZjTP4ayoyuGeO0X/ZPQiLEHIcA==", "649b89cf-27c4-4e8a-9e42-1306c513315f" });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                comment: "The user's status for today",
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true,
                oldComment: "The user's status for today");

            migrationBuilder.AlterColumn<string>(
                name: "AvatarImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                comment: "The user avatar image",
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldNullable: true,
                oldComment: "The user avatar image");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dfc2e14-723a-4de1-abe3-aacaafda3317", "AQAAAAIAAYagAAAAEG9m0Fju6GIQn2UEtlh8+x7jNvBfiLl/C5cbnedJE/HnItvs33ypk6cKiC9YqrwkQg==", "f415b9f9-7c2b-4b44-95ce-e5ecd7a70956" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "081b01a8-310d-4c44-86fd-c10ce0173ee7", "AQAAAAIAAYagAAAAEJ1QDXueOpa8O9RV/fWEkvfH1JTXyXNPEKLARA8KV/MvKS/KW/tY4dHyRrc5ehlq2g==", "9c6b181d-b37e-4e95-b352-4e4bf1113407" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 23, 41, 36, 235, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 23, 41, 36, 235, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 23, 41, 36, 235, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 23, 41, 36, 236, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 23, 41, 36, 231, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 23, 41, 36, 233, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 23, 41, 36, 234, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 16, 23, 41, 36, 234, DateTimeKind.Local).AddTicks(4090));
        }
    }
}

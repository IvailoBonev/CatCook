using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class LittleChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Tips",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tips",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1200)",
                oldMaxLength: 1200);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Forums",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "The title of the forum",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldComment: "The title of the forum");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a413247e-0ddc-42aa-aa9d-549695e00ef2", "AQAAAAIAAYagAAAAEFKQ22iL9xd+kDoej+N/VoIuTDF7WA8N7IDUx9QoI+KR7CH0UUutRl22i0hqIMhgIQ==", "95ec1405-a251-4433-b768-ad5fd0738cd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0eca05b8-e242-4e8b-b5c3-c2b70435a4d2", "AQAAAAIAAYagAAAAENeNh9fxVzdfNJfpm9RR/WwxkWhaRpK+PHNwjyF/5rzD0ubyl3j4MPiu6JCplc374Q==", "18f9b5b9-4e22-49d4-bf9e-b6df23df0993" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 7, 17, 22, 37, 439, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 7, 17, 22, 37, 439, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 7, 17, 22, 37, 439, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 7, 17, 22, 37, 439, DateTimeKind.Local).AddTicks(9861));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Tips",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tips",
                type: "nvarchar(1200)",
                maxLength: 1200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Forums",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                comment: "The title of the forum",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "The title of the forum");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7f8cf6d-222e-4946-a68f-2704a72bfcbb", "AQAAAAIAAYagAAAAEKmkqaHw3mGs1lXrmfK6tvJTZx87PMDSz384ecuKal8KhENrANMI2ciIP1MmDyS9rQ==", "06678bed-08d1-4499-b4dd-f1f4d7db26b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7845285-b269-40a8-b38e-eb121fc7fe8a", "AQAAAAIAAYagAAAAEH6oGz/Hkxwxlwu95nSWb9qG+m2ZPXTpu/CeApxbYix3E4PmIojjpiGEM23MSbL8qw==", "1653db78-5f15-4ea5-be5e-806a351306d7" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 4, 22, 0, 38, 81, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 4, 22, 0, 38, 81, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 4, 22, 0, 38, 81, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 4, 22, 0, 38, 81, DateTimeKind.Local).AddTicks(8924));
        }
    }
}

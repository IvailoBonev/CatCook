using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SoftDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Tips",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is the tip deleted (soft delete)");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Recipes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is the recipe deleted (soft delete)");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Forums",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is the forum deleted (soft delete)");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is the comment deleted (soft delete)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccac93a4-752f-4cf9-8c04-7d3ba52d8cad", "AQAAAAIAAYagAAAAEOC0/MUiDWfQ6SakmagPXTl9fSexQdAXVJpDFT/1bb5HK4wq2u4MP1yk0E8L5pLcJQ==", "e87932ec-b632-4314-bc81-2015c9efd953" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e223ec11-5d47-4276-b679-792b39f7d516", "AQAAAAIAAYagAAAAEMvJtJUqGStKGYP32C7tNuGmkx102yTFiXwAK0+Elqoo4iczIwuJtX0UFjq0cv8Y+A==", "9ef5d8df-c15e-4ae3-9e81-070fb2db05c2" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "IsDeleted" },
                values: new object[] { new DateTime(2024, 12, 3, 21, 14, 59, 44, DateTimeKind.Local).AddTicks(2486), false });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "IsDeleted" },
                values: new object[] { new DateTime(2024, 12, 3, 21, 14, 59, 52, DateTimeKind.Local).AddTicks(5044), false });

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Tips");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Forums");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14c789a0-c1e6-45c7-8d58-ff0dd16ce732", "AQAAAAIAAYagAAAAECO50sTjmWLzuUsf/RSdAaQFp0cC2geLKzN2SmPgT+p9iZU9YUBSRep9C2nZ/UbIog==", "f2612972-fb70-47f0-9e26-5edd3b80031f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20f70f85-b167-4a4a-a069-d38b448b4dec", "AQAAAAIAAYagAAAAENfdYzCo0PZR2u1sRWn3KPv09TujxZHXOSD/I/cgXDh/v7FdIvkn/0wmw4t9udKGnA==", "68fa058a-17c3-4f66-98be-614d22f1117c" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 1, 22, 37, 38, 431, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 1, 22, 37, 38, 431, DateTimeKind.Local).AddTicks(6658));
        }
    }
}

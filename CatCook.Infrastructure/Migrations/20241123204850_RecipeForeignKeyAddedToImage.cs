using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RecipeForeignKeyAddedToImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Recipes_RecipeId",
                table: "Images");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ed644e6-8b82-4589-a6f4-f61f2034c39c", "AQAAAAIAAYagAAAAEERe0e5w+rVXYpEZO1l8VgiQMk26vyYBwgYer7e4knzljq29INeCSnXmhKFFjL6Eaw==", "94418383-dfe7-4a09-bc88-9b3d1596f71f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36dc245d-cea0-42e8-aa69-96f09527ee30", "AQAAAAIAAYagAAAAELgXEXG3pCH2JVai7x6E0fD1PvSU6ZkEmmpzpZe1xmpFydnPUlxYe6/IoCXT+t5y+g==", "15244b55-af24-49c3-826e-aae90a9d235e" });


            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 11, 23, 22, 48, 49, 271, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 11, 23, 22, 48, 49, 271, DateTimeKind.Local).AddTicks(5894));

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Recipes_RecipeId",
                table: "Images",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Recipes_RecipeId",
                table: "Images");

            migrationBuilder.AlterColumn<int>(
                name: "RecipeId",
                table: "Images",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ForumId",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "599dfede-411a-41d8-b481-53e1c04fff55", "AQAAAAIAAYagAAAAEE88mWl/4kYNtZgONRkEel7NRYe9HSfypwaeDX9Kqoi+hD9X9msu+mSNVyo22EMOcQ==", "a6267106-04c5-4262-b6c8-6298f2c0e086" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bac7e87-9358-412a-b856-c3308c1589a6", "AQAAAAIAAYagAAAAEDaI1XsaaZLk1tliQD/wA2pLw0+62pmy1t9SWbdJQnTRPT1bFCkNJBh1Gr2TNYYqiQ==", "0951e08c-42e0-4ddb-a200-8d4243c2054c" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ForumId", "RecipeId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ForumId", "RecipeId" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 11, 23, 22, 44, 28, 332, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 11, 23, 22, 44, 28, 332, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.CreateIndex(
                name: "IX_Images_ForumId",
                table: "Images",
                column: "ForumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Forums_ForumId",
                table: "Images",
                column: "ForumId",
                principalTable: "Forums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Recipes_RecipeId",
                table: "Images",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id");
        }
    }
}

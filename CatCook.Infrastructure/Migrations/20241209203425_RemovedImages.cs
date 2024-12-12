using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemovedImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Image identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "The url of the image")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff9cbbc5-52aa-4d45-8fc4-291a90756031", "AQAAAAIAAYagAAAAEEbrcemFLlKjYH5uKoocZoLvdlLzhJxLL6kzqOqJfVIburO3vqDwDFhNLWaEhJhWWg==", "df376b04-21a9-4af6-a011-902035f2f612" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d3a9403-2eb0-4f08-b8ad-68d48270e381", "AQAAAAIAAYagAAAAEIZvKnCaEPeTh2dxinyZpzCbur2JUbiafPQa2TZfjQHYEqggjrBV46TqZGTQGWTP/w==", "0f22381e-db0a-4571-87a3-9f68848b38a9" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "ImageUrl", "RecipeId" },
                values: new object[,]
                {
                    { 1, "https://feelgoodfoodie.net/wp-content/uploads/2020/04/Caesar-Salad-TIMG.jpg", 1 },
                    { 2, "https://cakesbymk.com/wp-content/uploads/2023/11/Template-Size-for-Blog-Photos-24.jpg", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 9, 11, 40, 56, 977, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 9, 11, 40, 56, 977, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 9, 11, 40, 56, 977, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 9, 11, 40, 56, 977, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.CreateIndex(
                name: "IX_Images_RecipeId",
                table: "Images",
                column: "RecipeId");
        }
    }
}

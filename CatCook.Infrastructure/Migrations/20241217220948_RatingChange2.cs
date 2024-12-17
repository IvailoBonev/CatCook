using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RatingChange2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "900a6442-e1f0-4c7a-9add-503d04b2d183", "AQAAAAIAAYagAAAAEGqkjcKCj2xnDu9uBuXdOQhYLvTDg0NMXMRDTDyLdhZnJMtXat+IeBlGLNElusSurw==", "081480fb-651b-4107-a272-732149ee8989" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f24c6f5f-62bc-43d7-a46a-2faf6449f1a1", "AQAAAAIAAYagAAAAENMsy9bgOwIKR1segmFTWA+oEZZbdz4SrXPb7XiGRQQYa/64Y37an9OpdxcbqO+VHA==", "a418fc5f-66dd-4053-a68c-5cf402c4b7d3" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 9, 47, 462, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 9, 47, 462, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 9, 47, 463, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 9, 47, 463, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 9, 47, 458, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 9, 47, 461, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 9, 47, 461, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 9, 47, 461, DateTimeKind.Local).AddTicks(7840));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7f0a2ba-f34b-4f99-a191-399fa1c24bfb", "AQAAAAIAAYagAAAAEKnBflJShd/g2vfOmFVGvaw5+inWxNALC1xIy0EYQ76D/TGvImDz4607kmhfLQ5hmg==", "f9af9442-e1d6-4cbf-8f46-5938d7ca4167" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1e0c265-d738-4198-9000-9d9e0a88936a", "AQAAAAIAAYagAAAAEIejE7q9TEhFtCZX0UvkSKbaMyoxtaYmh728OGUVZLkCKCPK9zLv3g0Ft6Bqn8oTBw==", "dfa8d6f2-8d2e-4cb7-b69f-f0a6e230ebe4" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 8, 23, 797, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 8, 23, 797, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 8, 23, 797, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 8, 23, 797, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 8, 23, 791, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 8, 23, 794, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 8, 23, 795, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Tips",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 18, 0, 8, 23, 795, DateTimeKind.Local).AddTicks(4657));
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Stamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "400ca597-c97a-4167-9ce9-21255a545024", "AQAAAAIAAYagAAAAEEpgJaY+EdNSNweCiRdyrCZkmzR/tl//Fs/IiccKkL4IHZ7w0++1zuDqrRQ9qhKGzQ==", "c279d34a-cc09-4226-aecb-b83615e2f83e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbb37740-5fbe-4a71-9158-a5d985f4ffc6", "AQAAAAIAAYagAAAAEALi26rSCvM1BysyKmFgvaI91ud/b1KoUNItBbcGhfe3JG+iqpX6/SCO60AIaUjnJA==", "f6661968-608e-4715-a82e-bab75e617b84" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "085580e5-8fb3-447d-8bef-0435aa9d1e32", "AQAAAAIAAYagAAAAEFXpEcf0nSPz4dUFADELtaW8QZG1BMTTfPNobvcfnVFog+X6ldDbve9Fneau95PEPw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36998a40-6007-4cea-ac6e-c191880fa9e8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "887533e2-734f-418a-a833-33ccb94badf8", "AQAAAAIAAYagAAAAEMeVycsg/daKhGOW+Flhg3lGNhoEcEbKNeOjzGgkIe6x1uws74QwdYyDcnbANhmS6w==", null });
        }
    }
}

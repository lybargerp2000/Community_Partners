using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class number2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19905d2c-b33e-49e3-ae5e-3d7e94e51d04");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90f15a62-0bd2-4997-982a-7eb62ee09074");

            migrationBuilder.DropColumn(
                name: "RadiusMiles",
                table: "DonateServices");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "DonateServices",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DonationRadiusMiles",
                table: "DonateServices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01313b0f-4df1-43c6-b4de-488f7eecc343", "05ef0092-11fb-45c0-8dcc-8485cb479de3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea6c9a4e-e017-43f9-b746-a88711c7c692", "39187270-5f41-4e5c-b4aa-10a890b27f63", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01313b0f-4df1-43c6-b4de-488f7eecc343");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea6c9a4e-e017-43f9-b746-a88711c7c692");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "DonateServices");

            migrationBuilder.DropColumn(
                name: "DonationRadiusMiles",
                table: "DonateServices");

            migrationBuilder.AddColumn<int>(
                name: "RadiusMiles",
                table: "DonateServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90f15a62-0bd2-4997-982a-7eb62ee09074", "7cb39d17-5a00-40ea-8b5b-a2111b3bec74", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19905d2c-b33e-49e3-ae5e-3d7e94e51d04", "4d928d45-6f91-438b-8425-efc3efb89d4e", "Partner", "PARTNER" });
        }
    }
}

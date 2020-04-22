using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class UpdatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15e396fd-b6fc-406f-8432-3327cfa07cfb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfbaaf94-8fbe-4525-b987-bd54773a2454");

            migrationBuilder.AddColumn<int>(
                name: "RequestServiceId",
                table: "RequestServicePartnersers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DonateServiceId",
                table: "DonateServicePartnersers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed3518cb-a0a9-4b24-badc-87e7a58e6cab", "0f41fff7-d7a4-493f-89d5-ac2010556d99", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c4c4b68-afdf-4265-afd4-a28d19b028d3", "f04191e4-7643-42d0-952b-138a960bd36a", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c4c4b68-afdf-4265-afd4-a28d19b028d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed3518cb-a0a9-4b24-badc-87e7a58e6cab");

            migrationBuilder.DropColumn(
                name: "RequestServiceId",
                table: "RequestServicePartnersers");

            migrationBuilder.DropColumn(
                name: "DonateServiceId",
                table: "DonateServicePartnersers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "15e396fd-b6fc-406f-8432-3327cfa07cfb", "5e8f1ecc-8ad9-4a70-9d8a-1a3046f2a01d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dfbaaf94-8fbe-4525-b987-bd54773a2454", "cfe737ec-265d-4c6d-9b6c-996d71e4bad8", "Partner", "PARTNER" });
        }
    }
}

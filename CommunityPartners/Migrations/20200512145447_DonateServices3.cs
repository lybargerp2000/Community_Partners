using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class DonateServices3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e9ee8bf-908c-4739-ac7a-cd1038bb04f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4677c2ff-fe53-47e8-8610-c84ad032d164");

            migrationBuilder.AddColumn<string>(
                name: "PartnerLat",
                table: "DonateServices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartnerLong",
                table: "DonateServices",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4c3eb82-d856-4bb4-9b6e-3b6ae7775503", "60a8a10f-bc4a-4cd6-acd2-8327bc41b35a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "da3f24c1-b477-4439-965c-ee9dc193c211", "54e3bd16-993e-4a80-9ecf-49545bc5318b", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da3f24c1-b477-4439-965c-ee9dc193c211");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4c3eb82-d856-4bb4-9b6e-3b6ae7775503");

            migrationBuilder.DropColumn(
                name: "PartnerLat",
                table: "DonateServices");

            migrationBuilder.DropColumn(
                name: "PartnerLong",
                table: "DonateServices");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e9ee8bf-908c-4739-ac7a-cd1038bb04f4", "8f9b8940-966d-4a3b-9be7-2846773675cf", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4677c2ff-fe53-47e8-8610-c84ad032d164", "2aeb8b92-cac2-4344-805f-2f9697c72e48", "Partner", "PARTNER" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class RateServices3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b58b75a-f7f0-45e5-b3f6-fdb06dd3efe3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b70749b-9b61-4924-8909-1f45549744ab");

            migrationBuilder.AddColumn<string>(
                name: "PartnerLat",
                table: "RateServices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartnerLong",
                table: "RateServices",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e9ee8bf-908c-4739-ac7a-cd1038bb04f4", "8f9b8940-966d-4a3b-9be7-2846773675cf", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4677c2ff-fe53-47e8-8610-c84ad032d164", "2aeb8b92-cac2-4344-805f-2f9697c72e48", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e9ee8bf-908c-4739-ac7a-cd1038bb04f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4677c2ff-fe53-47e8-8610-c84ad032d164");

            migrationBuilder.DropColumn(
                name: "PartnerLat",
                table: "RateServices");

            migrationBuilder.DropColumn(
                name: "PartnerLong",
                table: "RateServices");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b70749b-9b61-4924-8909-1f45549744ab", "06e36d2f-a758-4538-8fd0-54573ff79065", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b58b75a-f7f0-45e5-b3f6-fdb06dd3efe3", "fc38525c-f77f-4691-9cef-6cb168004294", "Partner", "PARTNER" });
        }
    }
}

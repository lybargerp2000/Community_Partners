using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class PhoneNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da3f24c1-b477-4439-965c-ee9dc193c211");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4c3eb82-d856-4bb4-9b6e-3b6ae7775503");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "DonateServices",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0f7eb2c-7da2-4a97-9a2a-83b74036e2b2", "423a5729-1044-4781-bb56-f5eeaf32ba87", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f19e1dae-5cfa-4ca7-b91d-e70d85fac71d", "ed2c0036-4b74-4601-997b-00d66b196d24", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0f7eb2c-7da2-4a97-9a2a-83b74036e2b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f19e1dae-5cfa-4ca7-b91d-e70d85fac71d");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "DonateServices");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4c3eb82-d856-4bb4-9b6e-3b6ae7775503", "60a8a10f-bc4a-4cd6-acd2-8327bc41b35a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "da3f24c1-b477-4439-965c-ee9dc193c211", "54e3bd16-993e-4a80-9ecf-49545bc5318b", "Partner", "PARTNER" });
        }
    }
}

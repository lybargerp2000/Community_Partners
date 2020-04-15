using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5053a205-534d-4be4-a9c5-d63f2e2c9c1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56b37c6d-9018-4969-8332-042c3ed8eb55");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "48289b6e-88ef-4958-a120-7ae99bb45781", "2fc22565-e77e-455b-94b6-6ca34b59ed97", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6becf06e-6199-441d-b288-d1c72f4d78b0", "7c126810-d2b0-41ac-9068-c96e687a4de5", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48289b6e-88ef-4958-a120-7ae99bb45781");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6becf06e-6199-441d-b288-d1c72f4d78b0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "56b37c6d-9018-4969-8332-042c3ed8eb55", "ec4fda9e-be1d-4014-8ca2-c7c6d8dbe875", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5053a205-534d-4be4-a9c5-d63f2e2c9c1f", "8f289a70-9cbd-4c51-bff0-819e7dafb15d", "Partner", "PARTNER" });
        }
    }
}

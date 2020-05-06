using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class DonateService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6645de8f-83fa-4c02-9d63-f4c598cd6812");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "864a7d9d-f148-48fd-be57-02bdd39fbc4e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36d5d7cc-57b2-428d-a882-bc58c22e3849", "e17a7f7a-4e1d-4304-bc84-c60f48d69cb5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b60270a0-f2d0-4154-bfe7-a22fd3b1473c", "935d9994-938a-4cd2-ae59-7ebfa9bd66c7", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36d5d7cc-57b2-428d-a882-bc58c22e3849");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b60270a0-f2d0-4154-bfe7-a22fd3b1473c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "864a7d9d-f148-48fd-be57-02bdd39fbc4e", "34bb38ad-2e6f-42b4-b723-35c565247b1b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6645de8f-83fa-4c02-9d63-f4c598cd6812", "c8b69e45-fbf1-4713-af18-2e1d0db21e9f", "Partner", "PARTNER" });
        }
    }
}

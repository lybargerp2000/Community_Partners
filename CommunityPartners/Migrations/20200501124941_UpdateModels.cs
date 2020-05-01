using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class UpdateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dc2dafa-7fce-4db5-b671-f12c0f1e6044");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80eaba85-3a10-4403-a4e6-ec8c9de84c63");

            migrationBuilder.AddColumn<int>(
                name: "RatingHelpfulnessId",
                table: "Partners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "864a7d9d-f148-48fd-be57-02bdd39fbc4e", "34bb38ad-2e6f-42b4-b723-35c565247b1b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6645de8f-83fa-4c02-9d63-f4c598cd6812", "c8b69e45-fbf1-4713-af18-2e1d0db21e9f", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6645de8f-83fa-4c02-9d63-f4c598cd6812");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "864a7d9d-f148-48fd-be57-02bdd39fbc4e");

            migrationBuilder.DropColumn(
                name: "RatingHelpfulnessId",
                table: "Partners");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80eaba85-3a10-4403-a4e6-ec8c9de84c63", "db0b674f-4a8a-4b6f-9100-e95139d4dcee", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5dc2dafa-7fce-4db5-b671-f12c0f1e6044", "311b09d2-ae9b-4675-9a20-e1ad1878d683", "Partner", "PARTNER" });
        }
    }
}

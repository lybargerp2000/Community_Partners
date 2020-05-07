using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class MapView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20b4fc99-0f0a-4e28-b564-bc9a099cf86d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36949824-22cb-4a06-820a-33b05f8dcc0e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f2e2e66-5d6d-4a26-b8ed-6dcfdcbe9b1d", "4d583e9c-718a-47be-b30b-e54e91ce8d1f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9db89ae0-1f74-437b-b8f6-e9f7b78239ae", "8b7151c9-edc4-461e-9a7f-2595892dcfe8", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9db89ae0-1f74-437b-b8f6-e9f7b78239ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f2e2e66-5d6d-4a26-b8ed-6dcfdcbe9b1d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36949824-22cb-4a06-820a-33b05f8dcc0e", "a961d6b8-28f7-4c95-9589-d83536cd5b6b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20b4fc99-0f0a-4e28-b564-bc9a099cf86d", "9e02432b-ee66-4a43-bd27-8bb914c99240", "Partner", "PARTNER" });
        }
    }
}

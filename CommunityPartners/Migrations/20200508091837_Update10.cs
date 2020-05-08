using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class Update10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "9b1a7259-2077-4963-896c-1ae17295f8dc", "062e3210-7212-40ad-bc62-9ff08f542c87", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "688eeeba-e4e8-43c8-89e9-61c3a87c9ea3", "67b7aca7-8c52-4fcf-ab3d-ef2d1f19361e", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "688eeeba-e4e8-43c8-89e9-61c3a87c9ea3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b1a7259-2077-4963-896c-1ae17295f8dc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f2e2e66-5d6d-4a26-b8ed-6dcfdcbe9b1d", "4d583e9c-718a-47be-b30b-e54e91ce8d1f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9db89ae0-1f74-437b-b8f6-e9f7b78239ae", "8b7151c9-edc4-461e-9a7f-2595892dcfe8", "Partner", "PARTNER" });
        }
    }
}

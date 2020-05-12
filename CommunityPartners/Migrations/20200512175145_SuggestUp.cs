using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class SuggestUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0f7eb2c-7da2-4a97-9a2a-83b74036e2b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f19e1dae-5cfa-4ca7-b91d-e70d85fac71d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a0718028-02bd-46a3-80a1-c0d8e70334d4", "b6f75f05-bcbb-4003-b0b8-35f3215846a8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2469753-d665-4966-91b4-f37107143195", "0a6cb393-24eb-43f0-b1d2-bfea8ce12c58", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0718028-02bd-46a3-80a1-c0d8e70334d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2469753-d665-4966-91b4-f37107143195");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0f7eb2c-7da2-4a97-9a2a-83b74036e2b2", "423a5729-1044-4781-bb56-f5eeaf32ba87", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f19e1dae-5cfa-4ca7-b91d-e70d85fac71d", "ed2c0036-4b74-4601-997b-00d66b196d24", "Partner", "PARTNER" });
        }
    }
}

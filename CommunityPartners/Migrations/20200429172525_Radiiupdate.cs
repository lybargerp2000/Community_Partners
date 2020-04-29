using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class Radiiupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "261d660a-ed84-44b2-896c-5c0b5c4c6e0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3c6d999-9057-4a1f-a880-c11d3376d5af");

            migrationBuilder.AddColumn<int>(
                name: "PartnerId",
                table: "partnerRadii",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11eaecad-5a99-4eab-b08a-6fb50c5f7f0c", "dc6c1fa7-09b7-48ba-91bf-22d414755fac", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f511817e-1ac1-488d-98a2-8417db4c4559", "a22716c7-ed05-4a7c-9132-8e122e6748ba", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11eaecad-5a99-4eab-b08a-6fb50c5f7f0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f511817e-1ac1-488d-98a2-8417db4c4559");

            migrationBuilder.DropColumn(
                name: "PartnerId",
                table: "partnerRadii");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e3c6d999-9057-4a1f-a880-c11d3376d5af", "5655487d-825e-4920-91c1-0c579aca4be9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "261d660a-ed84-44b2-896c-5c0b5c4c6e0b", "f4de9172-4cf1-4c4c-9da7-b119895b2f88", "Partner", "PARTNER" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class PartnerUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11eaecad-5a99-4eab-b08a-6fb50c5f7f0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f511817e-1ac1-488d-98a2-8417db4c4559");

            migrationBuilder.AddColumn<int>(
                name: "PartnerRadiusId",
                table: "Partners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6ed58b88-1c6a-4fba-a08b-baa1e5b73fe0", "0e0dcf3c-bcca-495f-ba1a-8eb8cde25edf", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a7146945-83d0-4d73-b286-a5a01d0777aa", "9e75d7a1-f322-44d8-a762-8ab8fa02619c", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ed58b88-1c6a-4fba-a08b-baa1e5b73fe0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7146945-83d0-4d73-b286-a5a01d0777aa");

            migrationBuilder.DropColumn(
                name: "PartnerRadiusId",
                table: "Partners");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11eaecad-5a99-4eab-b08a-6fb50c5f7f0c", "dc6c1fa7-09b7-48ba-91bf-22d414755fac", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f511817e-1ac1-488d-98a2-8417db4c4559", "a22716c7-ed05-4a7c-9132-8e122e6748ba", "Partner", "PARTNER" });
        }
    }
}

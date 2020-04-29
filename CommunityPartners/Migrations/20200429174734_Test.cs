using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ed58b88-1c6a-4fba-a08b-baa1e5b73fe0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7146945-83d0-4d73-b286-a5a01d0777aa");

            migrationBuilder.AddColumn<int>(
                name: "PartnerTest",
                table: "Partners",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "432f250a-1da4-4446-a535-cf61c62cf925", "732b8c1c-e353-4fd4-a169-c624eb267c7e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d00e8731-a583-4995-b203-5fa28f979884", "3699d263-0d0b-492b-ada0-98230664069e", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "432f250a-1da4-4446-a535-cf61c62cf925");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d00e8731-a583-4995-b203-5fa28f979884");

            migrationBuilder.DropColumn(
                name: "PartnerTest",
                table: "Partners");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6ed58b88-1c6a-4fba-a08b-baa1e5b73fe0", "0e0dcf3c-bcca-495f-ba1a-8eb8cde25edf", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a7146945-83d0-4d73-b286-a5a01d0777aa", "9e75d7a1-f322-44d8-a762-8ab8fa02619c", "Partner", "PARTNER" });
        }
    }
}

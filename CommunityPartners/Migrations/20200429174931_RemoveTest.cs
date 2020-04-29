using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class RemoveTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "80eaba85-3a10-4403-a4e6-ec8c9de84c63", "db0b674f-4a8a-4b6f-9100-e95139d4dcee", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5dc2dafa-7fce-4db5-b671-f12c0f1e6044", "311b09d2-ae9b-4675-9a20-e1ad1878d683", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "PartnerTest",
                table: "Partners",
                type: "int",
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
    }
}

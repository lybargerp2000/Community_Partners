using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class DonateService2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90db573f-d3ef-43e1-84b5-e4f7aab91dcb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "957283d6-a807-42bd-a530-ca7b67c8b8c4");

            migrationBuilder.AddColumn<string>(
                name: "PartnerName",
                table: "DonateServices",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b70749b-9b61-4924-8909-1f45549744ab", "06e36d2f-a758-4538-8fd0-54573ff79065", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b58b75a-f7f0-45e5-b3f6-fdb06dd3efe3", "fc38525c-f77f-4691-9cef-6cb168004294", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b58b75a-f7f0-45e5-b3f6-fdb06dd3efe3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b70749b-9b61-4924-8909-1f45549744ab");

            migrationBuilder.DropColumn(
                name: "PartnerName",
                table: "DonateServices");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "957283d6-a807-42bd-a530-ca7b67c8b8c4", "8e851581-2d88-4309-8d6a-306a61c2068f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90db573f-d3ef-43e1-84b5-e4f7aab91dcb", "9c9f835d-5122-40e1-9241-d6e178410652", "Partner", "PARTNER" });
        }
    }
}

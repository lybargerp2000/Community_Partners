using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class addedFKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "688eeeba-e4e8-43c8-89e9-61c3a87c9ea3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b1a7259-2077-4963-896c-1ae17295f8dc");

            migrationBuilder.AddColumn<int>(
                name: "PartnerId",
                table: "RateServices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "56d0543d-bd02-4088-b206-a3ad026d16f1", "ee2100f7-9c9a-419f-8301-b1465cfe78c9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2019e47-1934-4301-8930-b9c4e00faad1", "48570f15-75c4-4777-b886-6087888a1aef", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56d0543d-bd02-4088-b206-a3ad026d16f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2019e47-1934-4301-8930-b9c4e00faad1");

            migrationBuilder.DropColumn(
                name: "PartnerId",
                table: "RateServices");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b1a7259-2077-4963-896c-1ae17295f8dc", "062e3210-7212-40ad-bc62-9ff08f542c87", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "688eeeba-e4e8-43c8-89e9-61c3a87c9ea3", "67b7aca7-8c52-4fcf-ab3d-ef2d1f19361e", "Partner", "PARTNER" });
        }
    }
}

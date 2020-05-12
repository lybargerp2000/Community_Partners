using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class RateService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56d0543d-bd02-4088-b206-a3ad026d16f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2019e47-1934-4301-8930-b9c4e00faad1");

            migrationBuilder.AddColumn<string>(
                name: "PartnerName",
                table: "RateServices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceDescription",
                table: "RateServices",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    ResultId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ratingSelect = table.Column<int>(nullable: false),
                    RateServiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => x.ResultId);
                    table.ForeignKey(
                        name: "FK_Result_RateServices_RateServiceId",
                        column: x => x.RateServiceId,
                        principalTable: "RateServices",
                        principalColumn: "RateServiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "957283d6-a807-42bd-a530-ca7b67c8b8c4", "8e851581-2d88-4309-8d6a-306a61c2068f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90db573f-d3ef-43e1-84b5-e4f7aab91dcb", "9c9f835d-5122-40e1-9241-d6e178410652", "Partner", "PARTNER" });

            migrationBuilder.CreateIndex(
                name: "IX_Result_RateServiceId",
                table: "Result",
                column: "RateServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90db573f-d3ef-43e1-84b5-e4f7aab91dcb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "957283d6-a807-42bd-a530-ca7b67c8b8c4");

            migrationBuilder.DropColumn(
                name: "PartnerName",
                table: "RateServices");

            migrationBuilder.DropColumn(
                name: "ServiceDescription",
                table: "RateServices");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "56d0543d-bd02-4088-b206-a3ad026d16f1", "ee2100f7-9c9a-419f-8301-b1465cfe78c9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2019e47-1934-4301-8930-b9c4e00faad1", "48570f15-75c4-4777-b886-6087888a1aef", "Partner", "PARTNER" });
        }
    }
}

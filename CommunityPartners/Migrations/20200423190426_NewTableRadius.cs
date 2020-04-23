using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class NewTableRadius : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "007b9399-0fde-4460-b36b-f2bda68dc4ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e04d62f1-5d08-4cd7-9d94-07db1273aaa6");

            migrationBuilder.CreateTable(
                name: "partnerRadii",
                columns: table => new
                {
                    PartnerRadiusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RadiusMiles = table.Column<int>(nullable: false),
                    RadiusMeters = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_partnerRadii", x => x.PartnerRadiusId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e3c6d999-9057-4a1f-a880-c11d3376d5af", "5655487d-825e-4920-91c1-0c579aca4be9", "Admin", "ADMIN" },
                    { "261d660a-ed84-44b2-896c-5c0b5c4c6e0b", "f4de9172-4cf1-4c4c-9da7-b119895b2f88", "Partner", "PARTNER" }
                });

            migrationBuilder.InsertData(
                table: "partnerRadii",
                columns: new[] { "PartnerRadiusId", "RadiusMeters", "RadiusMiles" },
                values: new object[,]
                {
                    { 1, 1600, 1 },
                    { 2, 8000, 5 },
                    { 3, 16000, 10 },
                    { 4, 50000, 30 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "partnerRadii");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "261d660a-ed84-44b2-896c-5c0b5c4c6e0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3c6d999-9057-4a1f-a880-c11d3376d5af");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e04d62f1-5d08-4cd7-9d94-07db1273aaa6", "71418188-c013-4b69-9f05-3494ee712a32", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "007b9399-0fde-4460-b36b-f2bda68dc4ca", "c7d46449-bc61-4d20-bd59-935c85252449", "Partner", "PARTNER" });
        }
    }
}

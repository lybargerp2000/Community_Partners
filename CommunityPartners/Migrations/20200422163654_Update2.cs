using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c4c4b68-afdf-4265-afd4-a28d19b028d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed3518cb-a0a9-4b24-badc-87e7a58e6cab");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e04d62f1-5d08-4cd7-9d94-07db1273aaa6", "71418188-c013-4b69-9f05-3494ee712a32", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "007b9399-0fde-4460-b36b-f2bda68dc4ca", "c7d46449-bc61-4d20-bd59-935c85252449", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "007b9399-0fde-4460-b36b-f2bda68dc4ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e04d62f1-5d08-4cd7-9d94-07db1273aaa6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed3518cb-a0a9-4b24-badc-87e7a58e6cab", "0f41fff7-d7a4-493f-89d5-ac2010556d99", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c4c4b68-afdf-4265-afd4-a28d19b028d3", "f04191e4-7643-42d0-952b-138a960bd36a", "Partner", "PARTNER" });
        }
    }
}

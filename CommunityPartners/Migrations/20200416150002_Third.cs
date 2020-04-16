using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityPartners.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonateServices_Partners_PartnerId",
                table: "DonateServices");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestServices_Partners_PartnerId",
                table: "RequestServices");

            migrationBuilder.DropIndex(
                name: "IX_RequestServices_PartnerId",
                table: "RequestServices");

            migrationBuilder.DropIndex(
                name: "IX_DonateServices_PartnerId",
                table: "DonateServices");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01313b0f-4df1-43c6-b4de-488f7eecc343");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea6c9a4e-e017-43f9-b746-a88711c7c692");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04d81418-f80b-4d20-87a9-72dfd404a5b1", "7e67ef5b-3dda-4bbe-9c34-6209b39b0da4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e63e8b0-dedd-44ee-9bf7-ae0aebec6d7f", "f87ba9aa-f2ba-46b4-ad7e-7b96ac83fae2", "Partner", "PARTNER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04d81418-f80b-4d20-87a9-72dfd404a5b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e63e8b0-dedd-44ee-9bf7-ae0aebec6d7f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01313b0f-4df1-43c6-b4de-488f7eecc343", "05ef0092-11fb-45c0-8dcc-8485cb479de3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea6c9a4e-e017-43f9-b746-a88711c7c692", "39187270-5f41-4e5c-b4aa-10a890b27f63", "Partner", "PARTNER" });

            migrationBuilder.CreateIndex(
                name: "IX_RequestServices_PartnerId",
                table: "RequestServices",
                column: "PartnerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DonateServices_PartnerId",
                table: "DonateServices",
                column: "PartnerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DonateServices_Partners_PartnerId",
                table: "DonateServices",
                column: "PartnerId",
                principalTable: "Partners",
                principalColumn: "PartnerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestServices_Partners_PartnerId",
                table: "RequestServices",
                column: "PartnerId",
                principalTable: "Partners",
                principalColumn: "PartnerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

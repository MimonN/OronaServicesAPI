using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OronaServicesAPI.Migrations
{
    public partial class IsItAHomeOrBussinessAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c021fa5-820f-4039-b0e0-db667b814e69");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfc8c0e0-74d0-4cca-90a7-7f162fccd3a9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c3e9e80-0758-474e-a000-465992989723", "2846ad8b-1803-46a3-baaf-4d87d634c3ad", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "594b19ea-33c1-4297-96e5-6a58ddffa863", "01bea0ee-f27e-410e-b84c-dce31cf909fe", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c3e9e80-0758-474e-a000-465992989723");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "594b19ea-33c1-4297-96e5-6a58ddffa863");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c021fa5-820f-4039-b0e0-db667b814e69", "a5b48f42-611d-4aab-9501-913e11d53c8f", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfc8c0e0-74d0-4cca-90a7-7f162fccd3a9", "10e3d9f3-ad3e-4272-aada-f07506a91105", "Administrator", "ADMINISTRATOR" });
        }
    }
}

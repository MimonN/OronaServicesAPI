using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OronaServicesAPI.Migrations
{
    public partial class AddedContactUsEntityToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "289ab0dc-95ff-4f6e-8b67-d63f7657c846");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bbb2cbd-9391-4836-8f69-7f89878671d0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b9327761-24fc-49a8-8d89-f4b87624a687", "6313b4c9-27f7-4bb2-a2c3-509a1021b08b", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d23e968b-5f5f-496a-859d-3166dcf8e244", "6b8319ae-120c-4c6d-b2b8-8ba9d9d1cd33", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9327761-24fc-49a8-8d89-f4b87624a687");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d23e968b-5f5f-496a-859d-3166dcf8e244");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "289ab0dc-95ff-4f6e-8b67-d63f7657c846", "2e89f628-7d29-4984-ac45-73987f4a4e68", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6bbb2cbd-9391-4836-8f69-7f89878671d0", "d11e1bad-e35d-4718-b3d9-7d3c063b82b3", "Administrator", "ADMINISTRATOR" });
        }
    }
}

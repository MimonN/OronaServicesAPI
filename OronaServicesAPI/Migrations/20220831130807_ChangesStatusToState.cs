using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OronaServicesAPI.Migrations
{
    public partial class ChangesStatusToState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c3e9e80-0758-474e-a000-465992989723");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "594b19ea-33c1-4297-96e5-6a58ddffa863");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ContactUs",
                newName: "State");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81ff3e77-d79e-417f-8089-82c2738755d7", "9ef48dd1-b5ad-4018-884d-132a63898db0", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8776bbf2-2c2b-4033-b6d3-31635345b750", "359dffac-09c8-448b-92d2-065b95374f60", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81ff3e77-d79e-417f-8089-82c2738755d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8776bbf2-2c2b-4033-b6d3-31635345b750");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "ContactUs",
                newName: "Status");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c3e9e80-0758-474e-a000-465992989723", "2846ad8b-1803-46a3-baaf-4d87d634c3ad", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "594b19ea-33c1-4297-96e5-6a58ddffa863", "01bea0ee-f27e-410e-b84c-dce31cf909fe", "Administrator", "ADMINISTRATOR" });
        }
    }
}

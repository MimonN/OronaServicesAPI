using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OronaServicesAPI.Migrations
{
    public partial class isItAHomeOrBusinessAddedToModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81ff3e77-d79e-417f-8089-82c2738755d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8776bbf2-2c2b-4033-b6d3-31635345b750");

            migrationBuilder.AddColumn<string>(
                name: "IsItAHomeOrBusiness",
                table: "ContactUs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5e944a7-86f9-412f-80a0-485b381d5b07", "242e8db2-b347-4b1e-b06f-5f9372048814", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "da552950-f720-4a24-a505-61547468a52f", "c8a95392-a846-480f-b4a2-4f5160b26500", "Viewer", "VIEWER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5e944a7-86f9-412f-80a0-485b381d5b07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da552950-f720-4a24-a505-61547468a52f");

            migrationBuilder.DropColumn(
                name: "IsItAHomeOrBusiness",
                table: "ContactUs");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81ff3e77-d79e-417f-8089-82c2738755d7", "9ef48dd1-b5ad-4018-884d-132a63898db0", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8776bbf2-2c2b-4033-b6d3-31635345b750", "359dffac-09c8-448b-92d2-065b95374f60", "Administrator", "ADMINISTRATOR" });
        }
    }
}

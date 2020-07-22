using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class RelationalUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Not",
                table: "NotTBLs");

            migrationBuilder.AddColumn<string>(
                name: "NotIcerik",
                table: "NotTBLs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotIcerik",
                table: "NotTBLs");

            migrationBuilder.AddColumn<string>(
                name: "Not",
                table: "NotTBLs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

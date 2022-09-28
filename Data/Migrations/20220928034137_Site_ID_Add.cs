using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Goals_Site.Data.Migrations
{
    public partial class Site_ID_Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "From_siteID",
                table: "Job",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "To_siteID",
                table: "Job",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "From_siteID",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "To_siteID",
                table: "Job");
        }
    }
}

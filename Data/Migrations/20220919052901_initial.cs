using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Goals_Site.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Phone = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Job_Number = table.Column<int>(type: "int", nullable: true),
                    Issue = table.Column<int>(type: "int", nullable: false),
                    Project_Manager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sales_Manager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client_Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client_Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Account_Info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Compliance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Site_Contact_From = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Site_Phone_From = table.Column<int>(type: "int", nullable: false),
                    Address_From = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Site_Contact_To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Site_Phone2_To = table.Column<int>(type: "int", nullable: true),
                    Address_To = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Phone = table.Column<int>(type: "int", nullable: false),
                    Stairs = table.Column<bool>(type: "bit", nullable: false),
                    Lift = table.Column<bool>(type: "bit", nullable: false),
                    Loading_Dock = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "Site");
        }
    }
}

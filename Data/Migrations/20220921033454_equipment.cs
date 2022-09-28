using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Goals_Site.Data.Migrations
{
    public partial class equipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    threeTonne_truck = table.Column<int>(type: "int", nullable: false),
                    MR = table.Column<int>(type: "int", nullable: false),
                    Pads = table.Column<int>(type: "int", nullable: false),
                    Workstation_trolley = table.Column<int>(type: "int", nullable: false),
                    Bubble_wrap = table.Column<int>(type: "int", nullable: false),
                    Camera = table.Column<int>(type: "int", nullable: false),
                    Stocktake_sheets = table.Column<int>(type: "int", nullable: false),
                    Fridge_trolley = table.Column<int>(type: "int", nullable: false),
                    Electronics_bin = table.Column<int>(type: "int", nullable: false),
                    High_vis = table.Column<int>(type: "int", nullable: false),
                    IT_trolley = table.Column<int>(type: "int", nullable: false),
                    File_trolley = table.Column<int>(type: "int", nullable: false),
                    Butchers_paper = table.Column<int>(type: "int", nullable: false),
                    Corrugated_cardboard = table.Column<int>(type: "int", nullable: false),
                    GAN_blanklabels = table.Column<int>(type: "int", nullable: false),
                    Recycle_wastebin = table.Column<int>(type: "int", nullable: false),
                    Nitrile_gloves = table.Column<int>(type: "int", nullable: false),
                    IT_shelves = table.Column<int>(type: "int", nullable: false),
                    Bollards = table.Column<int>(type: "int", nullable: false),
                    Shrink_wrap = table.Column<int>(type: "int", nullable: false),
                    Antistatic_bag = table.Column<int>(type: "int", nullable: false),
                    Floorlift_protection = table.Column<int>(type: "int", nullable: false),
                    A4location_labels = table.Column<int>(type: "int", nullable: false),
                    General_waste_bin = table.Column<int>(type: "int", nullable: false),
                    Toll_roads = table.Column<int>(type: "int", nullable: false),
                    Drill = table.Column<int>(type: "int", nullable: false),
                    Supervisors_bag = table.Column<int>(type: "int", nullable: false),
                    Dollies = table.Column<int>(type: "int", nullable: false),
                    Crowbar = table.Column<int>(type: "int", nullable: false),
                    Packing_tape = table.Column<int>(type: "int", nullable: false),
                    Ziplock_itbag = table.Column<int>(type: "int", nullable: false),
                    Access_passes = table.Column<int>(type: "int", nullable: false),
                    A3floor_plans = table.Column<int>(type: "int", nullable: false),
                    Cleaning_products = table.Column<int>(type: "int", nullable: false),
                    Jelly_beans = table.Column<int>(type: "int", nullable: false),
                    Cable_ties = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.EquipmentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipment");
        }
    }
}

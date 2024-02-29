using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aairport.Data.Migrations
{
    public partial class manytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdFlight",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FlightPilot",
                columns: table => new
                {
                    FlightsId = table.Column<int>(type: "int", nullable: false),
                    PilotsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightPilot", x => new { x.FlightsId, x.PilotsId });
                    table.ForeignKey(
                        name: "FK_FlightPilot_Flights_FlightsId",
                        column: x => x.FlightsId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightPilot_Pilots_PilotsId",
                        column: x => x.PilotsId,
                        principalTable: "Pilots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightPilot_PilotsId",
                table: "FlightPilot",
                column: "PilotsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightPilot");

            migrationBuilder.DropColumn(
                name: "IdFlight",
                table: "Passengers");
        }
    }
}

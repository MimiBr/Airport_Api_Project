using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aairport.Data.Migrations
{
    public partial class onetomanyy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdFlight",
                table: "Passengers",
                newName: "flightId");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_flightId",
                table: "Passengers",
                column: "flightId");

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Flights_flightId",
                table: "Passengers",
                column: "flightId",
                principalTable: "Flights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Flights_flightId",
                table: "Passengers");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_flightId",
                table: "Passengers");

            migrationBuilder.RenameColumn(
                name: "flightId",
                table: "Passengers",
                newName: "IdFlight");
        }
    }
}

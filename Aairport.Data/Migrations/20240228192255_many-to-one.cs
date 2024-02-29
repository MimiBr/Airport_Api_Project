using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aairport.Data.Migrations
{
    public partial class manytoone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdFlight",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdFlight",
                table: "Passengers");
        }
    }
}

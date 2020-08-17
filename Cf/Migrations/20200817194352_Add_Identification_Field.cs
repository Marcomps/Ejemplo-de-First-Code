using Microsoft.EntityFrameworkCore.Migrations;

namespace Cf.Migrations
{
    public partial class Add_Identification_Field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Identification",
                table: "People",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Identification",
                table: "People");
        }
    }
}

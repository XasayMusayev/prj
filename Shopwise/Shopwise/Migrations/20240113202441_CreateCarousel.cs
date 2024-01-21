using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopwise.Migrations
{
    public partial class CreateCarousel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShortDesc",
                table: "Sliders",
                newName: "Bgimage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Bgimage",
                table: "Sliders",
                newName: "ShortDesc");
        }
    }
}

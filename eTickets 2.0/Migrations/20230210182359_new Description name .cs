using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets_2._0.Migrations
{
    public partial class newDescriptionname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripiton",
                table: "Cinemas",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cinemas",
                newName: "Descripiton");
        }
    }
}

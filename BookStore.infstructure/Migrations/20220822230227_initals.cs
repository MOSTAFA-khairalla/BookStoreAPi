using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.infstructure.Migrations
{
    public partial class initals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "Books",
                newName: "ImageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Books",
                newName: "Photo");
        }
    }
}

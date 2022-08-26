using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.infstructure.Migrations
{
    public partial class s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ORIGINALFILEnAME",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ORIGINALFILEnAME",
                table: "Books",
                type: "varchar(150)",
                nullable: false,
                defaultValue: "");
        }
    }
}

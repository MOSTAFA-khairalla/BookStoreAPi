using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.infstructure.Migrations
{
    public partial class ORIGRANL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ORIGINALFILEnAME",
                table: "Books",
                type: "varchar(150)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ORIGINALFILEnAME",
                table: "Books");
        }
    }
}

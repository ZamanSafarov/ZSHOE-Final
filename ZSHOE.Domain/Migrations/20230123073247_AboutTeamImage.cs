using Microsoft.EntityFrameworkCore.Migrations;

namespace ZSHOE.Domain.Migrations
{
    public partial class AboutTeamImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "AboutTeam",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "AboutTeam");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ZSHOE.Domain.Migrations
{
    public partial class AboutTeamSlug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "AboutTeam",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "AboutTeam");
        }
    }
}

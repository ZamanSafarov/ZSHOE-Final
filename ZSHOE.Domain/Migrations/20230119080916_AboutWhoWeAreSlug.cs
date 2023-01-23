using Microsoft.EntityFrameworkCore.Migrations;

namespace ZSHOE.Domain.Migrations
{
    public partial class AboutWhoWeAreSlug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "AboutWhoWeAre",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "AboutWhoWeAre");
        }
    }
}

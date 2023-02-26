using Microsoft.EntityFrameworkCore.Migrations;

namespace ZSHOE.Domain.Migrations
{
    public partial class ContactImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "ContactInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "ContactInfos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "ContactInfos");
        }
    }
}

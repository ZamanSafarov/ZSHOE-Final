using Microsoft.EntityFrameworkCore.Migrations;

namespace ZSHOE.Domain.Migrations
{
    public partial class Basket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                schema: "Membership",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                schema: "Membership",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCatalogItems",
                table: "ProductCatalogItems");

            migrationBuilder.DropIndex(
                name: "IX_ProductCatalogItems_ProductId",
                table: "ProductCatalogItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                schema: "Membership",
                table: "UserRoles");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "Membership",
                newName: "UserRole",
                newSchema: "Membership");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_RoleId",
                schema: "Membership",
                table: "UserRole",
                newName: "IX_UserRole_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCatalogItems",
                table: "ProductCatalogItems",
                columns: new[] { "ProductId", "ColorId", "MaterialId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                schema: "Membership",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.CreateTable(
                name: "Basket",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basket", x => new { x.UserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_Basket_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Basket_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Membership",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Basket_ProductId",
                table: "Basket",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Roles_RoleId",
                schema: "Membership",
                table: "UserRole",
                column: "RoleId",
                principalSchema: "Membership",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Users_UserId",
                schema: "Membership",
                table: "UserRole",
                column: "UserId",
                principalSchema: "Membership",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Roles_RoleId",
                schema: "Membership",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Users_UserId",
                schema: "Membership",
                table: "UserRole");

            migrationBuilder.DropTable(
                name: "Basket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCatalogItems",
                table: "ProductCatalogItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                schema: "Membership",
                table: "UserRole");

            migrationBuilder.RenameTable(
                name: "UserRole",
                schema: "Membership",
                newName: "UserRoles",
                newSchema: "Membership");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_RoleId",
                schema: "Membership",
                table: "UserRoles",
                newName: "IX_UserRoles_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCatalogItems",
                table: "ProductCatalogItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                schema: "Membership",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCatalogItems_ProductId",
                table: "ProductCatalogItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                schema: "Membership",
                table: "UserRoles",
                column: "RoleId",
                principalSchema: "Membership",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                schema: "Membership",
                table: "UserRoles",
                column: "UserId",
                principalSchema: "Membership",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

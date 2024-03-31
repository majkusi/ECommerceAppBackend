using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceAppBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserShopCartModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShopCartId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ShopCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_ShopCarts_CartId",
                        column: x => x.CartId,
                        principalTable: "ShopCarts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_ShopCartId",
                table: "Items",
                column: "ShopCartId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopCarts_UserId",
                table: "ShopCarts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CartId",
                table: "Users",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ShopCarts_ShopCartId",
                table: "Items",
                column: "ShopCartId",
                principalTable: "ShopCarts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCarts_Users_UserId",
                table: "ShopCarts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ShopCarts_ShopCartId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopCarts_Users_UserId",
                table: "ShopCarts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ShopCarts");

            migrationBuilder.DropIndex(
                name: "IX_Items_ShopCartId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ShopCartId",
                table: "Items");
        }
    }
}

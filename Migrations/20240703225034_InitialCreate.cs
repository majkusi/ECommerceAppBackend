using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceAppBackend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemProducerModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemProducerModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemTypeModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTypeModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    InStock = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProducerId = table.Column<int>(type: "int", nullable: true),
                    ItemTypeId = table.Column<int>(type: "int", nullable: true),
                    ShopCartModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_ItemProducerModel_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "ItemProducerModel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Items_ItemTypeModel_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemTypeModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShopCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserModelId = table.Column<int>(type: "int", nullable: true)
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
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: true),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Discount", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber", "ShopCartModelId" },
                values: new object[,]
                {
                    { 1, "Description for Sony Noise Cancelling Headphones", null, 45, null, "Asus Gaming Mouse", 989.71000000000004, null, "889799", null },
                    { 2, "Description for Canon DSLR Camera", null, 60, null, "Microsoft Surface Pro", 296.48000000000002, null, "957749", null },
                    { 3, "Description for Logitech Mouse Pro", null, 19, null, "Canon DSLR Camera", 204.80000000000001, null, "418881", null },
                    { 4, "Description for Logitech Mouse Pro", null, 13, null, "Sony Noise Cancelling Headphones", 34.340000000000003, null, "938647", null },
                    { 5, "Description for Amazon Echo Dot", null, 3, null, "LG UltraWide Monitor", 507.56, null, "161185", null },
                    { 6, "Description for Logitech Mouse Pro", null, 47, null, "Dell Inspiron Laptop", 814.21000000000004, null, "577542", null },
                    { 7, "Description for Logitech Mouse Pro", null, 85, null, "Samsung Smart TV", 165.38, null, "230609", null },
                    { 8, "Description for Amazon Echo Dot", null, 48, null, "Asus Gaming Mouse", 273.38, null, "425166", null },
                    { 9, "Description for Asus Gaming Mouse", null, 36, null, "Asus Gaming Mouse", 332.55000000000001, null, "483017", null },
                    { 10, "Description for GoPro Hero Action Camera", null, 84, null, "Logitech Mouse Pro", 551.13, null, "316862", null },
                    { 11, "Description for JBL Portable Bluetooth Speaker", null, 11, null, "Asus Gaming Mouse", 981.49000000000001, null, "995603", null },
                    { 12, "Description for Apple iPhone 13", null, 6, null, "Nintendo Switch", 767.72000000000003, null, "123214", null },
                    { 13, "Description for GoPro Hero Action Camera", null, 54, null, "Asus Gaming Mouse", 267.44, null, "343905", null },
                    { 14, "Description for Google Nest Thermostat", null, 95, null, "Dell Inspiron Laptop", 379.50999999999999, null, "362511", null },
                    { 15, "Description for Lenovo ThinkPad Laptop", null, 80, null, "Dell Inspiron Laptop", 624.78999999999996, null, "712048", null },
                    { 16, "Description for Google Nest Thermostat", null, 84, null, "GoPro Hero Action Camera", 469.87, null, "157300", null },
                    { 17, "Description for Sony Noise Cancelling Headphones", null, 15, null, "GoPro Hero Action Camera", 209.97, null, "573792", null },
                    { 18, "Description for Sony Noise Cancelling Headphones", null, 22, null, "LG UltraWide Monitor", 455.04000000000002, null, "158977", null },
                    { 19, "Description for Logitech Mouse Pro", null, 90, null, "JBL Portable Bluetooth Speaker", 543.05999999999995, null, "585542", null },
                    { 20, "Description for GoPro Hero Action Camera", null, 30, null, "Lenovo ThinkPad Laptop", 811.82000000000005, null, "722857", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemTypeId",
                table: "Items",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ProducerId",
                table: "Items",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ShopCartModelId",
                table: "Items",
                column: "ShopCartModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopCarts_UserModelId",
                table: "ShopCarts",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CartId",
                table: "Users",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ShopCarts_ShopCartModelId",
                table: "Items",
                column: "ShopCartModelId",
                principalTable: "ShopCarts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCarts_Users_UserModelId",
                table: "ShopCarts",
                column: "UserModelId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_ShopCarts_CartId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "ItemProducerModel");

            migrationBuilder.DropTable(
                name: "ItemTypeModel");

            migrationBuilder.DropTable(
                name: "ShopCarts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

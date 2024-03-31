using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceAppBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddedItemTypeItemProducerModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ShopCarts_ShopCartId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopCarts_Users_UserId",
                table: "ShopCarts");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ShopCarts",
                newName: "UserModelId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopCarts_UserId",
                table: "ShopCarts",
                newName: "IX_ShopCarts_UserModelId");

            migrationBuilder.RenameColumn(
                name: "ShopCartId",
                table: "Items",
                newName: "ShopCartModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ShopCartId",
                table: "Items",
                newName: "IX_Items_ShopCartModelId");

            migrationBuilder.AddColumn<int>(
                name: "ItemTypeId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProducerId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for Apple iPhone 13", 88, null, "Amazon Echo Dot", 147.97, null, "332690" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for Google Nest Thermostat", 52, null, "Samsung Smart TV", 2.1899999999999999, null, "451389" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for HP LaserJet Printer", 75, null, "Apple iPhone 13", 208.72, null, "725262" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for Bose Soundbar", 32, null, "JBL Portable Bluetooth Speaker", 711.99000000000001, null, "209950" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for Fitbit Versa Smartwatch", 30, null, "Sony Noise Cancelling Headphones", 27.899999999999999, null, "676120" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { 54, null, "Nintendo Switch", 842.89999999999998, null, "531479" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for GoPro Hero Action Camera", 9, null, "Dell Inspiron Laptop", 381.16000000000003, null, "457629" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for Sony Noise Cancelling Headphones", 31, null, "HP LaserJet Printer", 59.590000000000003, null, "863213" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for Asus Gaming Mouse", 2, null, "Lenovo ThinkPad Laptop", 682.86000000000001, null, "321784" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for GoPro Hero Action Camera", 63, null, "Google Nest Thermostat", 714.41999999999996, null, "773948" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for Microsoft Surface Pro", 66, null, "Asus Gaming Mouse", 287.68000000000001, null, "210582" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for Fitbit Versa Smartwatch", 89, null, "Asus Gaming Mouse", 650.79999999999995, null, "455839" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for Google Nest Thermostat", 45, null, "Lenovo ThinkPad Laptop", 595.29999999999995, null, "429858" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for Apple iPhone 13", 47, null, "Bose Soundbar", 902.94000000000005, null, "335696" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for Logitech Mouse Pro", 58, null, "Dell Inspiron Laptop", 509.29000000000002, null, "796690" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for Sony Noise Cancelling Headphones", 31, null, "Amazon Echo Dot", 955.48000000000002, null, "206303" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for LG UltraWide Monitor", 9, null, "Fitbit Versa Smartwatch", 168.61000000000001, null, "836442" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for Microsoft Surface Pro", 2, null, "Fitbit Versa Smartwatch", 789.41999999999996, null, "181930" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for Dell Inspiron Laptop", 9, null, "Apple iPhone 13", 682.37, null, "255013" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "InStock", "ItemTypeId", "Name", "Price", "ProducerId", "SerialNumber" },
                values: new object[] { "Description for Fitbit Versa Smartwatch", 45, null, "Dell Inspiron Laptop", 741.98000000000002, null, "315586" });

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemTypeId",
                table: "Items",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ProducerId",
                table: "Items",
                column: "ProducerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemProducerModel_ProducerId",
                table: "Items",
                column: "ProducerId",
                principalTable: "ItemProducerModel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemTypeModel_ItemTypeId",
                table: "Items",
                column: "ItemTypeId",
                principalTable: "ItemTypeModel",
                principalColumn: "Id");

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
                name: "FK_Items_ItemProducerModel_ProducerId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemTypeModel_ItemTypeId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ShopCarts_ShopCartModelId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopCarts_Users_UserModelId",
                table: "ShopCarts");

            migrationBuilder.DropTable(
                name: "ItemProducerModel");

            migrationBuilder.DropTable(
                name: "ItemTypeModel");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemTypeId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ProducerId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemTypeId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ProducerId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "UserModelId",
                table: "ShopCarts",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopCarts_UserModelId",
                table: "ShopCarts",
                newName: "IX_ShopCarts_UserId");

            migrationBuilder.RenameColumn(
                name: "ShopCartModelId",
                table: "Items",
                newName: "ShopCartId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ShopCartModelId",
                table: "Items",
                newName: "IX_Items_ShopCartId");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Canon DSLR Camera", 71, "Garmin GPS Watch", 175.91 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for JBL Portable Bluetooth Speaker", 40, "Logitech Mouse Pro", 413.45999999999998 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Sony Noise Cancelling Headphones", 11, "Fitbit Versa Smartwatch", 306.5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Canon DSLR Camera", 87, "GoPro Hero Action Camera", 712.77999999999997 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Philips Coffee Machine", 42, "Nintendo Switch", 187.28999999999999 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InStock", "Name", "Price" },
                values: new object[] { 17, "Asus Gaming Mouse", 737.13999999999999 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Dell Inspiron Laptop", 94, "GoPro Hero Action Camera", 528.48000000000002 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Philips Coffee Machine", 97, "Canon DSLR Camera", 82.219999999999999 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Amazon Echo Dot", 44, "Bose Soundbar", 926.54999999999995 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Asus Gaming Mouse", 77, "HP LaserJet Printer", 108.17 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Apple iPhone 13", 60, "Lenovo ThinkPad Laptop", 476.38 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Samsung Smart TV", 42, "GoPro Hero Action Camera", 957.69000000000005 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Canon DSLR Camera", 20, "LG UltraWide Monitor", 610.40999999999997 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Amazon Echo Dot", 61, "Canon DSLR Camera", 832.89999999999998 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Microsoft Surface Pro", 46, "Bose Soundbar", 604.51999999999998 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Google Nest Thermostat", 20, "HP LaserJet Printer", 169.91 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Samsung Smart TV", 43, "Asus Gaming Mouse", 660.94000000000005 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Fitbit Versa Smartwatch", 96, "Garmin GPS Watch", 34.049999999999997 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Asus Gaming Mouse", 94, "LG UltraWide Monitor", 242.13 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "InStock", "Name", "Price" },
                values: new object[] { "Description for Canon DSLR Camera", 93, "Amazon Echo Dot", 848.62 });

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
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceAppBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddedSampleItemData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Discount", "InStock", "Name", "Price", "ShopCartId" },
                values: new object[,]
                {
                    { 1, "Description for Canon DSLR Camera", null, 71, "Garmin GPS Watch", 175.91, null },
                    { 2, "Description for JBL Portable Bluetooth Speaker", null, 40, "Logitech Mouse Pro", 413.45999999999998, null },
                    { 3, "Description for Sony Noise Cancelling Headphones", null, 11, "Fitbit Versa Smartwatch", 306.5, null },
                    { 4, "Description for Canon DSLR Camera", null, 87, "GoPro Hero Action Camera", 712.77999999999997, null },
                    { 5, "Description for Philips Coffee Machine", null, 42, "Nintendo Switch", 187.28999999999999, null },
                    { 6, "Description for Logitech Mouse Pro", null, 17, "Asus Gaming Mouse", 737.13999999999999, null },
                    { 7, "Description for Dell Inspiron Laptop", null, 94, "GoPro Hero Action Camera", 528.48000000000002, null },
                    { 8, "Description for Philips Coffee Machine", null, 97, "Canon DSLR Camera", 82.219999999999999, null },
                    { 9, "Description for Amazon Echo Dot", null, 44, "Bose Soundbar", 926.54999999999995, null },
                    { 10, "Description for Asus Gaming Mouse", null, 77, "HP LaserJet Printer", 108.17, null },
                    { 11, "Description for Apple iPhone 13", null, 60, "Lenovo ThinkPad Laptop", 476.38, null },
                    { 12, "Description for Samsung Smart TV", null, 42, "GoPro Hero Action Camera", 957.69000000000005, null },
                    { 13, "Description for Canon DSLR Camera", null, 20, "LG UltraWide Monitor", 610.40999999999997, null },
                    { 14, "Description for Amazon Echo Dot", null, 61, "Canon DSLR Camera", 832.89999999999998, null },
                    { 15, "Description for Microsoft Surface Pro", null, 46, "Bose Soundbar", 604.51999999999998, null },
                    { 16, "Description for Google Nest Thermostat", null, 20, "HP LaserJet Printer", 169.91, null },
                    { 17, "Description for Samsung Smart TV", null, 43, "Asus Gaming Mouse", 660.94000000000005, null },
                    { 18, "Description for Fitbit Versa Smartwatch", null, 96, "Garmin GPS Watch", 34.049999999999997, null },
                    { 19, "Description for Asus Gaming Mouse", null, 94, "LG UltraWide Monitor", 242.13, null },
                    { 20, "Description for Canon DSLR Camera", null, 93, "Amazon Echo Dot", 848.62, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}

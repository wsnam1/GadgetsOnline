using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GadgetsOnline.Migrations
{
    public partial class tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Latest collection of Mobile Phones", "Mobile Phones" },
                    { 2, "Latest Laptops in 2022", "Laptops" },
                    { 3, "Latest Desktops in 2022", "Desktops" },
                    { 4, "Latest audio devices", "Audio" },
                    { 5, "USB Cables, Mobile chargers and Keyboards etc", "Accessories" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Name", "Price", "ProductArtUrl" },
                values: new object[,]
                {
                    { 1, 1, "Phone 12", 699.00m, "/Content/Images/Mobile/1.jpg" },
                    { 2, 1, "Phone 13 Pro", 999.00m, "/Content/Images/Mobile/2.jpg" },
                    { 3, 1, "Phone 13 Pro Max", 1199.00m, "/Content/Images/Mobile/3.jpg" },
                    { 4, 2, "XTS 13'", 899.00m, "/Content/Images/Laptop/1.jpg" },
                    { 5, 2, "PC 15.5'", 479.00m, "/Content/Images/Laptop/2.jpg" },
                    { 6, 2, "Notebook 14", 169.00m, "/Content/Images/Laptop/3.jpg" },
                    { 7, 3, "The IdeaCenter", 539.00m, "/Content/Images/placeholder.gif" },
                    { 8, 3, "COMP 22-df003w", 389.00m, "/Content/Images/placeholder.gif" },
                    { 9, 4, "Bluetooth Headphones Over Ear", 28.00m, "/Content/Images/Headphones/1.png" },
                    { 10, 4, "ZX Series ", 10.00m, "/Content/Images/Headphones/2.png" },
                    { 11, 5, "Wireless charger", 9.99m, "/Content/Images/placeholder.gif" },
                    { 12, 5, "Mousepad", 2.99m, "/Content/Images/placeholder.gif" },
                    { 13, 5, "Keyboard", 9.99m, "/Content/Images/placeholder.gif" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);
        }
    }
}

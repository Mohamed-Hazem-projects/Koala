using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory.Data.Migrations
{
    /// <inheritdoc />
    public partial class productsDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 0, 0, 8, 521, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 0, 0, 8, 526, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 0, 0, 8, 526, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 0, 0, 8, 526, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 0, 0, 8, 526, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreateAt", "Description", "Name", "Price", "SupplierId" },
                values: new object[] { 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(5310), "Automotive Products", "Saudi Arabia Flag", 804m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreateAt", "Description", "Name", "Price", "SupplierId" },
                values: new object[] { 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8671), "Toys", "Textbook", 394m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreateAt", "Description", "Name", "Price", "SupplierId" },
                values: new object[] { 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8706), "Home Appliances", "Laptop", 740m, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Description", "Image", "Name", "Price", "SupplierId" },
                values: new object[,]
                {
                    { 4, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8714), "Beauty Products", null, "TV", 72m, 5 },
                    { 5, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8722), "Garden Equipment", null, "Saudi Arabia Flag", 490m, 4 },
                    { 6, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8742), "Furniture", null, "Smartphone", 113m, 3 },
                    { 7, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8749), "Electronics Products", null, "Sofa", 607m, 5 },
                    { 8, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8756), "Books", null, "Power Bank", 664m, 2 },
                    { 9, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8763), "Electronics Products", null, "Camera", 99m, 1 },
                    { 10, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8772), "Sports Equipment", null, "Dining Table", 833m, 4 },
                    { 11, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8864), "Flags Products", null, "Palestine Flag", 9m, 1 },
                    { 12, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8873), "Flags Products", null, "Egypt Flag", 8m, 2 },
                    { 13, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8909), "Flags Products", null, "Saudi Arabia Flag", 10m, 3 },
                    { 14, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8917), "Electronics Products", null, "Laptop", 500m, 1 },
                    { 15, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8923), "Electronics Products", null, "Smartphone", 300m, 2 },
                    { 16, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8930), "Electronics Products", null, "Tablet", 200m, 3 },
                    { 17, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8936), "Home Appliances", null, "Refrigerator", 800m, 4 },
                    { 18, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8946), "Home Appliances", null, "Washing Machine", 600m, 5 },
                    { 19, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8952), "Home Appliances", null, "Microwave", 150m, 4 },
                    { 20, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8959), "Furniture", null, "Sofa", 350m, 1 },
                    { 21, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8965), "Furniture", null, "Dining Table", 450m, 2 },
                    { 22, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8972), "Furniture", null, "Bed Frame", 400m, 3 },
                    { 23, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8978), "Books", null, "Novel", 15m, 1 },
                    { 24, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8985), "Books", null, "Cookbook", 20m, 2 },
                    { 25, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8992), "Books", null, "Textbook", 30m, 3 },
                    { 26, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(8998), "Furniture", null, "Monitor", 180m, 2 },
                    { 27, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9004), "Beauty Products", null, "Wardrobe", 615m, 1 },
                    { 28, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9011), "Toys", null, "Mirror", 563m, 1 },
                    { 29, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9035), "Electronics Products", null, "Cookbook", 243m, 3 },
                    { 30, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9042), "Flags Products", null, "Heater", 5m, 4 },
                    { 31, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9048), "Kitchen Appliances", null, "Rug", 336m, 2 },
                    { 32, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9055), "Home Appliances", null, "Iron", 874m, 1 },
                    { 33, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9062), "Games", null, "Textbook", 436m, 2 },
                    { 34, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9072), "Flags Products", null, "Monitor", 927m, 3 },
                    { 35, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9078), "Musical Instruments", null, "Sofa", 201m, 5 },
                    { 36, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9085), "Musical Instruments", null, "Cookbook", 399m, 4 },
                    { 37, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9091), "Kitchen Appliances", null, "Egypt Flag", 549m, 2 },
                    { 38, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9098), "Toys", null, "Laptop", 442m, 3 },
                    { 39, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9105), "Books", null, "Bed Frame", 657m, 5 },
                    { 40, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9112), "Electronics Products", null, "Charger", 257m, 3 },
                    { 41, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9118), "Automotive Products", null, "Tablet", 639m, 4 },
                    { 42, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9125), "Home Appliances", null, "Headphones", 676m, 5 },
                    { 43, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9131), "Flags Products", null, "Dining Table", 161m, 1 },
                    { 44, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9138), "Flags Products", null, "Palestine Flag", 9m, 1 },
                    { 45, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9161), "Flags Products", null, "Lebanon Flag", 10m, 2 },
                    { 46, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9168), "Flags Products", null, "USA Flag", 12m, 3 },
                    { 47, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9175), "Flags Products", null, "China Flag", 8m, 4 },
                    { 48, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9182), "Flags Products", null, "Brazil Flag", 11m, 5 },
                    { 49, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9188), "Flags Products", null, "Germany Flag", 10m, 1 },
                    { 50, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9195), "Flags Products", null, "France Flag", 9m, 2 },
                    { 51, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9201), "Flags Products", null, "UK Flag", 13m, 3 },
                    { 52, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9208), "Flags Products", null, "Russia Flag", 9m, 4 },
                    { 53, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9214), "Flags Products", null, "Italy Flag", 10m, 5 },
                    { 54, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9220), "Tech Gadgets", null, "Flash Drive", 50m, 3 },
                    { 55, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9226), "Stationery", null, "Notebook", 12m, 1 },
                    { 56, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9232), "Fashion Accessories", null, "Wristband", 20m, 4 },
                    { 57, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9238), "Flags Products", null, "Palestine Flag", 9m, 2 },
                    { 58, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9244), "Tech Gadgets", null, "Portable Speaker", 40m, 5 },
                    { 59, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9250), "Office Supplies", null, "Calendar", 18m, 3 },
                    { 60, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9256), "Electronics", null, "Headphones", 65m, 2 },
                    { 61, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9279), "Clothing and Apparel", null, "Cap", 15m, 1 },
                    { 62, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9286), "Travel Essentials", null, "Water Bottle", 25m, 4 },
                    { 63, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9292), "Home Decor", null, "Poster", 8m, 2 },
                    { 64, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9298), "Flags Products", null, "Palestine Flag", 10m, 2 },
                    { 65, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9378), "Office Supplies", null, "Coffee Mug", 15m, 4 },
                    { 66, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9389), "Flags Products", null, "Jordan Flag", 8m, 1 },
                    { 67, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9395), "Fashion Accessories", null, "Keychain", 5m, 3 },
                    { 68, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9401), "Fashion Accessories", null, "Sunglasses", 25m, 5 },
                    { 69, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9407), "Clothing and Apparel", null, "T-shirt", 18m, 2 },
                    { 70, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9413), "Stationery", null, "Notebook", 12m, 1 },
                    { 71, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9419), "Fashion Accessories", null, "Bracelet", 20m, 4 },
                    { 72, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9425), "Stationery", null, "Laptop Sticker", 7m, 5 },
                    { 73, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9431), "Office Supplies", null, "Pen", 6m, 3 },
                    { 74, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9437), "Tech Gadgets", null, "Headphones", 50m, 2 },
                    { 75, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9443), "Tech Gadgets", null, "Portable Speaker", 55m, 4 },
                    { 76, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9449), "Travel Essentials", null, "Water Bottle", 20m, 5 },
                    { 77, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9455), "Home Decor", null, "Poster", 10m, 1 },
                    { 78, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9479), "Tech Gadgets", null, "Phone Case", 15m, 3 },
                    { 79, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9486), "Travel Essentials", null, "Backpack", 30m, 2 },
                    { 80, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9492), "Tech Gadgets", null, "Smartwatch", 80m, 4 },
                    { 81, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9498), "Travel Essentials", null, "Travel Bag", 35m, 5 },
                    { 82, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9504), "Tech Gadgets", null, "Power Bank", 25m, 3 },
                    { 83, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9510), "Tech Gadgets", null, "Flash Drive", 10m, 2 },
                    { 84, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9516), "Office Supplies", null, "Calendar", 8m, 1 },
                    { 85, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9522), "Office Supplies", null, "Mouse Pad", 12m, 4 },
                    { 86, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9528), "Tech Gadgets", null, "Charger", 15m, 5 },
                    { 87, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9534), "Fashion Accessories", null, "Wristband", 10m, 2 },
                    { 88, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9540), "Flags Products", null, "Syria Flag", 9m, 3 },
                    { 89, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9546), "Travel Essentials", null, "Umbrella", 12m, 4 },
                    { 90, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9552), "Flags Products", null, "Lebanon Flag", 7m, 5 },
                    { 91, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9558), "Office Supplies", null, "Desk Organizer", 18m, 1 },
                    { 92, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9564), "Home Decor", null, "Poster", 9m, 2 },
                    { 93, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9570), "Tech Gadgets", null, "Headphones", 55m, 3 },
                    { 94, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9594), "Fashion Accessories", null, "Keychain", 5m, 4 },
                    { 95, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9600), "Tech Gadgets", null, "Smartwatch", 90m, 5 },
                    { 96, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9606), "Office Supplies", null, "Pen", 6m, 2 },
                    { 97, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9612), "Stationery", null, "Notebook", 14m, 3 },
                    { 98, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9618), "Clothing and Apparel", null, "Cap", 12m, 4 },
                    { 99, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9624), "Fashion Accessories", null, "Sunglasses", 25m, 1 },
                    { 100, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9630), "Fashion Accessories", null, "Bracelet", 20m, 3 },
                    { 101, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9636), "Tech Gadgets", null, "Phone Case", 15m, 2 },
                    { 102, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9642), "Travel Essentials", null, "Backpack", 32m, 5 },
                    { 103, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9649), "Travel Essentials", null, "Water Bottle", 18m, 4 },
                    { 104, 2, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9655), "Stationery", null, "Laptop Sticker", 6m, 1 },
                    { 105, 5, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9661), "Tech Gadgets", null, "Charger", 16m, 2 },
                    { 106, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9667), "Tech Gadgets", null, "Flash Drive", 12m, 3 },
                    { 107, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9673), "Fashion Accessories", null, "Wristband", 11m, 5 },
                    { 108, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9679), "Office Supplies", null, "Calendar", 8m, 4 },
                    { 109, 3, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9685), "Office Supplies", null, "Pen", 7m, 1 },
                    { 110, 4, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9691), "Travel Essentials", null, "Travel Bag", 36m, 3 },
                    { 111, 1, new DateTime(2024, 10, 9, 0, 0, 8, 538, DateTimeKind.Local).AddTicks(9698), "Stationery", null, "Notebook", 13m, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 0, 0, 8, 528, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 0, 0, 8, 528, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 0, 0, 8, 528, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 0, 0, 8, 528, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 0, 0, 8, 528, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 0, 0, 8, 529, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 0, 0, 8, 529, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 0, 0, 8, 529, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "Id", "CreateAt", "Name" },
                values: new object[,]
                {
                    { 4, new DateTime(2024, 10, 9, 0, 0, 8, 529, DateTimeKind.Local).AddTicks(1397), "Section D" },
                    { 5, new DateTime(2024, 10, 9, 0, 0, 8, 529, DateTimeKind.Local).AddTicks(1402), "Section E" }
                });

            migrationBuilder.UpdateData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CurrentStock", "MaxStock", "MinStock" },
                values: new object[] { (short)18, (short)44, (short)9 });

            migrationBuilder.InsertData(
                table: "WareHousesProducts",
                columns: new[] { "ProductID", "WareHouseID", "CurrentStock", "MaxStock", "MinStock" },
                values: new object[,]
                {
                    { 1, 4, (short)12, (short)41, (short)7 },
                    { 3, 5, (short)16, (short)45, (short)12 },
                    { 4, 2, (short)10, (short)38, (short)8 },
                    { 5, 3, (short)19, (short)50, (short)15 },
                    { 6, 1, (short)11, (short)37, (short)6 },
                    { 7, 2, (short)18, (short)42, (short)10 },
                    { 8, 4, (short)22, (short)47, (short)14 },
                    { 9, 3, (short)15, (short)40, (short)11 },
                    { 10, 5, (short)13, (short)43, (short)9 },
                    { 11, 1, (short)14, (short)40, (short)8 },
                    { 12, 3, (short)9, (short)35, (short)7 },
                    { 13, 5, (short)12, (short)44, (short)10 },
                    { 14, 4, (short)10, (short)38, (short)6 },
                    { 15, 2, (short)16, (short)46, (short)12 },
                    { 16, 1, (short)18, (short)47, (short)14 },
                    { 17, 5, (short)12, (short)39, (short)9 },
                    { 18, 3, (short)14, (short)43, (short)11 },
                    { 19, 2, (short)17, (short)42, (short)10 },
                    { 20, 4, (short)13, (short)41, (short)8 },
                    { 21, 1, (short)11, (short)38, (short)6 },
                    { 22, 3, (short)18, (short)45, (short)12 },
                    { 23, 5, (short)10, (short)36, (short)7 },
                    { 24, 2, (short)20, (short)49, (short)15 },
                    { 25, 4, (short)12, (short)43, (short)9 },
                    { 26, 1, (short)17, (short)46, (short)11 },
                    { 27, 3, (short)19, (short)48, (short)14 },
                    { 28, 5, (short)13, (short)42, (short)10 },
                    { 29, 4, (short)16, (short)44, (short)12 },
                    { 30, 2, (short)12, (short)39, (short)8 },
                    { 31, 1, (short)10, (short)37, (short)6 },
                    { 32, 3, (short)17, (short)47, (short)13 },
                    { 33, 5, (short)15, (short)41, (short)11 },
                    { 34, 4, (short)13, (short)40, (short)9 },
                    { 35, 2, (short)11, (short)35, (short)7 },
                    { 36, 1, (short)18, (short)45, (short)12 },
                    { 37, 3, (short)13, (short)42, (short)10 },
                    { 38, 5, (short)12, (short)40, (short)9 },
                    { 39, 4, (short)17, (short)46, (short)11 },
                    { 40, 2, (short)12, (short)38, (short)8 },
                    { 41, 1, (short)10, (short)36, (short)6 },
                    { 42, 3, (short)20, (short)50, (short)15 },
                    { 43, 5, (short)14, (short)44, (short)10 },
                    { 44, 4, (short)12, (short)41, (short)9 },
                    { 45, 2, (short)18, (short)47, (short)12 },
                    { 46, 1, (short)13, (short)40, (short)8 },
                    { 47, 3, (short)14, (short)43, (short)11 },
                    { 48, 5, (short)9, (short)35, (short)7 },
                    { 49, 4, (short)17, (short)46, (short)13 },
                    { 50, 2, (short)14, (short)42, (short)10 },
                    { 51, 1, (short)12, (short)39, (short)9 },
                    { 52, 3, (short)18, (short)48, (short)14 },
                    { 53, 5, (short)15, (short)42, (short)11 },
                    { 54, 1, (short)12, (short)40, (short)8 },
                    { 55, 4, (short)11, (short)35, (short)6 },
                    { 56, 2, (short)14, (short)43, (short)10 },
                    { 57, 5, (short)16, (short)46, (short)11 },
                    { 58, 3, (short)13, (short)41, (short)9 },
                    { 59, 1, (short)10, (short)36, (short)7 },
                    { 60, 2, (short)19, (short)48, (short)14 },
                    { 61, 4, (short)13, (short)40, (short)8 },
                    { 62, 5, (short)18, (short)47, (short)12 },
                    { 63, 3, (short)14, (short)44, (short)10 },
                    { 64, 1, (short)9, (short)34, (short)6 },
                    { 65, 4, (short)18, (short)46, (short)13 },
                    { 66, 2, (short)12, (short)39, (short)9 },
                    { 67, 3, (short)20, (short)49, (short)15 },
                    { 68, 5, (short)13, (short)42, (short)10 },
                    { 69, 1, (short)11, (short)38, (short)7 },
                    { 70, 4, (short)19, (short)47, (short)14 },
                    { 71, 2, (short)16, (short)45, (short)12 },
                    { 72, 3, (short)13, (short)40, (short)9 },
                    { 73, 5, (short)17, (short)46, (short)11 },
                    { 74, 1, (short)12, (short)39, (short)8 },
                    { 75, 4, (short)15, (short)43, (short)10 },
                    { 76, 3, (short)18, (short)48, (short)13 },
                    { 77, 2, (short)10, (short)36, (short)6 },
                    { 78, 5, (short)16, (short)45, (short)12 },
                    { 79, 1, (short)14, (short)42, (short)9 },
                    { 80, 4, (short)13, (short)41, (short)8 },
                    { 81, 3, (short)10, (short)37, (short)7 },
                    { 82, 2, (short)15, (short)44, (short)11 },
                    { 83, 5, (short)19, (short)48, (short)14 },
                    { 84, 1, (short)9, (short)35, (short)6 },
                    { 85, 4, (short)16, (short)46, (short)12 },
                    { 86, 3, (short)13, (short)42, (short)10 },
                    { 87, 2, (short)11, (short)40, (short)8 },
                    { 88, 5, (short)10, (short)38, (short)7 },
                    { 89, 1, (short)12, (short)43, (short)9 },
                    { 90, 4, (short)15, (short)44, (short)11 },
                    { 91, 3, (short)18, (short)49, (short)13 },
                    { 92, 2, (short)14, (short)43, (short)10 },
                    { 93, 5, (short)11, (short)39, (short)8 },
                    { 94, 1, (short)17, (short)46, (short)12 },
                    { 95, 4, (short)19, (short)50, (short)14 },
                    { 96, 3, (short)16, (short)45, (short)11 },
                    { 97, 2, (short)10, (short)36, (short)7 },
                    { 98, 5, (short)12, (short)43, (short)9 },
                    { 99, 1, (short)12, (short)40, (short)8 },
                    { 100, 4, (short)9, (short)35, (short)6 },
                    { 101, 3, (short)13, (short)43, (short)10 },
                    { 102, 2, (short)17, (short)46, (short)11 },
                    { 103, 5, (short)16, (short)47, (short)12 },
                    { 104, 1, (short)10, (short)39, (short)7 },
                    { 105, 3, (short)14, (short)42, (short)9 },
                    { 106, 2, (short)11, (short)38, (short)8 },
                    { 107, 4, (short)15, (short)43, (short)10 },
                    { 108, 5, (short)17, (short)46, (short)11 },
                    { 109, 1, (short)12, (short)39, (short)7 },
                    { 110, 2, (short)18, (short)45, (short)12 },
                    { 111, 3, (short)14, (short)42, (short)9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 22, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 23, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 25, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 29, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 30, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 32, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 33, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 34, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 35, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 37, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 38, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 39, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 40, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 41, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 42, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 43, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 44, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 45, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 46, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 47, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 48, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 49, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 50, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 52, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 53, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 54, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 55, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 56, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 57, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 58, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 60, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 61, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 62, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 63, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 64, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 65, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 66, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 67, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 68, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 69, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 70, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 71, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 72, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 73, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 74, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 75, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 76, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 77, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 78, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 79, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 80, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 81, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 82, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 83, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 84, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 85, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 86, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 87, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 88, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 89, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 90, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 91, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 92, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 93, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 94, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 95, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 96, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 97, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 98, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 99, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 100, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 101, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 102, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 103, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 104, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 105, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 106, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 107, 4 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 108, 5 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 109, 1 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 110, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 111, 3 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 8, 3, 22, 5, 959, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 8, 3, 22, 5, 963, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 8, 3, 22, 5, 963, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 8, 3, 22, 5, 963, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 8, 3, 22, 5, 963, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreateAt", "Description", "Name", "Price", "SupplierId" },
                values: new object[] { null, new DateTime(2024, 10, 8, 3, 22, 5, 966, DateTimeKind.Local).AddTicks(5888), "Flags Products", "Palestine Flag", 9m, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreateAt", "Description", "Name", "Price", "SupplierId" },
                values: new object[] { null, new DateTime(2024, 10, 8, 3, 22, 5, 966, DateTimeKind.Local).AddTicks(8082), "Guns Products", "Gun AK-74", 1000m, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreateAt", "Description", "Name", "Price", "SupplierId" },
                values: new object[] { null, new DateTime(2024, 10, 8, 3, 22, 5, 966, DateTimeKind.Local).AddTicks(8115), "Food Products", "زبادي", 3m, null });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 8, 3, 22, 5, 965, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 8, 3, 22, 5, 965, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 8, 3, 22, 5, 965, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 8, 3, 22, 5, 965, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 8, 3, 22, 5, 965, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 8, 3, 22, 5, 966, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 8, 3, 22, 5, 966, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 8, 3, 22, 5, 966, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CurrentStock", "MaxStock", "MinStock" },
                values: new object[] { (short)8, (short)25, (short)3 });

            migrationBuilder.InsertData(
                table: "WareHousesProducts",
                columns: new[] { "ProductID", "WareHouseID", "CurrentStock", "MaxStock", "MinStock" },
                values: new object[,]
                {
                    { 1, 1, (short)20, (short)50, (short)10 },
                    { 1, 2, (short)15, (short)40, (short)5 },
                    { 2, 3, (short)12, (short)30, (short)7 },
                    { 3, 2, (short)5, (short)10, (short)4 },
                    { 3, 3, (short)20, (short)50, (short)15 }
                });
        }
    }
}

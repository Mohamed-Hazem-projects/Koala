﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone_Number = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email_Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rating = table.Column<byte>(type: "tinyint", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WareHouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "WareHousesProducts",
                columns: table => new
                {
                    WareHouseID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    MinStock = table.Column<short>(type: "smallint", nullable: false),
                    CurrentStock = table.Column<short>(type: "smallint", nullable: false),
                    MaxStock = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHousesProducts", x => new { x.ProductID, x.WareHouseID });
                    table.ForeignKey(
                        name: "FK_WareHousesProducts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WareHousesProducts_WareHouses_WareHouseID",
                        column: x => x.WareHouseID,
                        principalTable: "WareHouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemsSold = table.Column<int>(type: "int", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    WareHouseId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_WareHousesProducts_ProductId_WareHouseId",
                        columns: x => new { x.ProductId, x.WareHouseId },
                        principalTable: "WareHousesProducts",
                        principalColumns: new[] { "ProductID", "WareHouseID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e8efb33-73d1-4cff-b5bc-5a3786a5e9e0", null, "WHManager2", "WHMANAGER2" },
                    { "21c4cdf5-fb00-4682-9702-73e2b1bef97a", null, "WHManager4", "WHMANAGER4" },
                    { "378afc4c-7b8d-4792-ae45-46cdc659f85a", null, "WHManager1", "WHMANAGER1" },
                    { "90339032-2b27-453a-b28f-ce462947f27e", null, "Admin", "ADMIN" },
                    { "a09063e9-2695-46f5-903b-de48900ed64b", null, "WHManager3", "WHMANAGER3" },
                    { "b0b3a53d-f99e-4a4f-a792-8ad7b7467cc4", null, "Staff", "STAFF" },
                    { "d43e9c99-70bb-49bb-b73f-81165b9e6e7a", null, "WHManager5", "WHMANAGER5" },
                    { "f736c3be-297d-4472-bfee-0a504b9e32e3", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 15, 17, 15, 24, 37, DateTimeKind.Local).AddTicks(1051), "Electronics" },
                    { 2, new DateTime(2024, 10, 15, 17, 15, 24, 47, DateTimeKind.Local).AddTicks(9924), "Clothing" },
                    { 3, new DateTime(2024, 10, 15, 17, 15, 24, 47, DateTimeKind.Local).AddTicks(9958), "Groceries" },
                    { 4, new DateTime(2024, 10, 15, 17, 15, 24, 47, DateTimeKind.Local).AddTicks(9962), "Furniture" },
                    { 5, new DateTime(2024, 10, 15, 17, 15, 24, 47, DateTimeKind.Local).AddTicks(9964), "Accessories" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "CreateAt", "Email_Address", "Image", "Name", "Phone_Number", "Rating" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 15, 17, 15, 24, 49, DateTimeKind.Local).AddTicks(1389), "pyramidsmail@pyr.com", null, "Misr Pyramids Group", "01523456789", (byte)7 },
                    { 2, new DateTime(2024, 10, 15, 17, 15, 24, 49, DateTimeKind.Local).AddTicks(3082), "hero@basics.com", null, "Hero Basics", "01283492232", (byte)5 },
                    { 3, new DateTime(2024, 10, 15, 17, 15, 24, 49, DateTimeKind.Local).AddTicks(3102), "Resi@trade.com", null, "Resi Trade", "01129555939", (byte)9 },
                    { 4, new DateTime(2024, 10, 15, 17, 15, 24, 49, DateTimeKind.Local).AddTicks(3106), "Lamar@gmail.com", null, "lamar", "01522233333", (byte)3 },
                    { 5, new DateTime(2024, 10, 15, 17, 15, 24, 49, DateTimeKind.Local).AddTicks(3109), "info@Hazlam.com", null, "Hazlam", "01575732113", (byte)8 }
                });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "Id", "CreateAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 15, 17, 15, 24, 49, DateTimeKind.Local).AddTicks(6863), "SwiftStore" },
                    { 2, new DateTime(2024, 10, 15, 17, 15, 24, 49, DateTimeKind.Local).AddTicks(7257), "OptiStock" },
                    { 3, new DateTime(2024, 10, 15, 17, 15, 24, 49, DateTimeKind.Local).AddTicks(7271), "Nexus Dist" },
                    { 4, new DateTime(2024, 10, 15, 17, 15, 24, 49, DateTimeKind.Local).AddTicks(7274), "PrimeSpace" },
                    { 5, new DateTime(2024, 10, 15, 17, 15, 24, 49, DateTimeKind.Local).AddTicks(7277), "AgileHub" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Description", "Image", "Name", "Price", "SupplierId" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2024, 10, 15, 17, 15, 24, 55, DateTimeKind.Local).AddTicks(8243), "High-quality Saudi Arabia flag for display", null, "Saudi Arabia Flag", 804m, 2 },
                    { 2, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(239), "Comprehensive textbook for Mathematics", null, "Textbook - Mathematics", 394m, 4 },
                    { 3, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(259), "Powerful laptop for home and office use", null, "Laptop", 740m, 2 },
                    { 4, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(263), "Slim and stylish 40-inch smart TV", null, "TV - 40 Inch", 72m, 5 },
                    { 5, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(266), "Essential garden tools set for outdoor tasks", null, "Garden Tools Set", 490m, 4 },
                    { 6, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(282), "High-performance smartphone with a large display", null, "Smartphone - Pro Edition", 113m, 3 },
                    { 7, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(286), "Elegant leather sofa for living room", null, "Leather Sofa", 607m, 5 },
                    { 8, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(289), "Fast-charging power bank for mobile devices", null, "Portable Power Bank", 664m, 2 },
                    { 9, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(292), "Compact digital camera with high resolution", null, "Digital Camera", 99m, 1 },
                    { 10, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(297), "Solid wood dining table with modern design", null, "Wooden Dining Table", 833m, 4 },
                    { 11, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(300), "National Palestine flag for home and events", null, "Palestine Flag", 9m, 1 },
                    { 12, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(303), "Flag of Egypt, durable and fade-resistant", null, "Egypt Flag", 8m, 2 },
                    { 13, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(306), "Premium Saudi Arabia flag for outdoor use", null, "Flag of Saudi Arabia", 10m, 3 },
                    { 14, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(310), "High-end gaming laptop with advanced graphics", null, "Gaming Laptop", 500m, 1 },
                    { 15, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(313), "Compact smartphone with essential features", null, "Smartphone - Mini Edition", 300m, 2 },
                    { 16, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(316), "10-inch tablet with large display and fast processor", null, "Tablet - 10 Inch", 200m, 3 },
                    { 17, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(319), "Spacious double door refrigerator", null, "Refrigerator - Double Door", 800m, 4 },
                    { 18, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(324), "Energy-efficient washing machine", null, "Washing Machine", 600m, 5 },
                    { 19, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(328), "Compact microwave oven with multiple settings", null, "Microwave Oven", 150m, 4 },
                    { 20, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(331), "Stylish and comfortable modern sofa", null, "Modern Sofa", 350m, 1 },
                    { 21, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(335), "Classic dining table for six", null, "Classic Dining Table", 450m, 2 },
                    { 22, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(338), "Sturdy queen-size bed frame", null, "Bed Frame - Queen Size", 400m, 3 },
                    { 23, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(341), "Fiction novel by a best-selling author", null, "Novel - Fiction", 15m, 1 },
                    { 24, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(344), "Collection of healthy recipes", null, "Cookbook - Healthy Recipes", 20m, 2 },
                    { 25, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(347), "Educational science textbook for students", null, "Science Textbook", 30m, 3 },
                    { 26, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(350), "High-resolution LCD monitor for desktop", null, "LCD Monitor", 180m, 2 },
                    { 27, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(354), "Spacious 3-door wardrobe for bedrooms", null, "Wardrobe - 3 Door", 615m, 1 },
                    { 28, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(357), "Decorative wall mirror for living room", null, "Wall Mirror", 563m, 1 },
                    { 29, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(360), "Cookbook with quick and easy meal recipes", null, "Cookbook - Quick Meals", 243m, 3 },
                    { 30, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(363), "Portable electric heater for home", null, "Electric Heater", 5m, 4 },
                    { 31, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(366), "Soft kitchen rug with non-slip backing", null, "Kitchen Rug", 336m, 2 },
                    { 32, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(369), "Powerful steam iron for wrinkle-free clothes", null, "Steam Iron", 874m, 1 },
                    { 33, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(372), "Textbook on game theory and applications", null, "Game Theory Textbook", 436m, 2 },
                    { 34, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(377), "Large curved monitor for immersive experience", null, "Curved Monitor", 927m, 3 },
                    { 35, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(380), "Comfortable leather sofa for three people", null, "Leather Sofa - 3 Seater", 201m, 5 },
                    { 36, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(384), "Essential cookbook for baking recipes", null, "Cookbook - Baking Essentials", 399m, 4 },
                    { 37, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(387), "Durable Egypt flag for all occasions", null, "Egypt Flag", 549m, 2 },
                    { 38, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(390), "Durable laptop for children's learning", null, "Laptop - Kid's Edition", 442m, 3 },
                    { 39, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(393), "Elegant king-size bed frame", null, "Bed Frame - King Size", 657m, 5 },
                    { 40, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(396), "Fast USB charger for multiple devices", null, "USB Charger", 257m, 3 },
                    { 41, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(502), "Convertible tablet for mobile and desktop use", null, "Convertible Tablet", 639m, 4 },
                    { 42, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(506), "Headphones with noise-cancelling feature", null, "Noise Cancelling Headphones", 676m, 5 },
                    { 43, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(509), "Extendable dining table for extra seating", null, "Extendable Dining Table", 161m, 1 },
                    { 44, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(513), "Miniature Palestine flag for display", null, "Palestine Flag - Mini", 9m, 1 },
                    { 45, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(516), "High-quality Lebanon flag", null, "Lebanon Flag", 10m, 2 },
                    { 46, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(519), "Durable USA flag for outdoor use", null, "USA Flag", 12m, 1 },
                    { 47, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(522), "Quality China flag for display", null, "China Flag", 8m, 4 },
                    { 48, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(525), "Vibrant Brazil flag for all occasions", null, "Brazil Flag", 11m, 5 },
                    { 49, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(528), "Germany flag for international events", null, "Germany Flag", 10m, 1 },
                    { 50, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(531), "Classic France flag for outdoor use", null, "France Flag", 9m, 2 },
                    { 51, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(535), "United Kingdom flag for all seasons", null, "UK Flag", 13m, 3 },
                    { 52, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(538), "Durable Russia flag for display", null, "Russia Flag", 9m, 4 },
                    { 53, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(541), "High-quality Italy flag for indoor and outdoor use", null, "Italy Flag", 10m, 5 },
                    { 54, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(545), "Portable USB flash drive with 16GB capacity", null, "USB Flash Drive", 50m, 3 },
                    { 55, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(548), "Compact notebook for notes and ideas", null, "Notebook - A5 Size", 12m, 1 },
                    { 56, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(551), "Smart fitness wristband for activity tracking", null, "Fitness Wristband", 20m, 4 },
                    { 57, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(554), "Large Palestine flag for official events", null, "Palestine Flag - Large", 9m, 2 },
                    { 58, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(557), "Portable Bluetooth speaker with deep bass", null, "Bluetooth Speaker", 40m, 5 },
                    { 59, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(560), "Compact desk calendar for office use", null, "Desk Calendar", 18m, 3 },
                    { 60, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(563), "Comfortable wireless headphones with long battery life", null, "Wireless Headphones", 65m, 2 },
                    { 61, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(566), "Classic baseball cap with adjustable strap", null, "Baseball Cap", 15m, 1 },
                    { 62, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(569), "Stainless steel insulated water bottle", null, "Insulated Water Bottle", 25m, 4 },
                    { 63, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(572), "Artistic wall poster for home decoration", null, "Wall Poster - Art", 8m, 2 },
                    { 64, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(576), "Small Palestine flag for personal use", null, "Palestine Flag - Small", 10m, 2 },
                    { 65, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(579), "Durable ceramic coffee mug for office or home", null, "Ceramic Coffee Mug", 15m, 4 },
                    { 66, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(584), "Jordan flag with vibrant colors", null, "Jordan Flag", 8m, 1 },
                    { 67, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(587), "Durable metal keychain with modern design", null, "Metal Keychain", 5m, 3 },
                    { 68, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(591), "Polarized sunglasses for UV protection", null, "Polarized Sunglasses", 25m, 5 },
                    { 69, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(594), "Comfortable graphic t-shirt with unique design", null, "Graphic T-Shirt", 18m, 2 },
                    { 70, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(597), "Durable hardcover notebook for everyday use", null, "Hardcover Notebook", 12m, 1 },
                    { 71, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(600), "Stylish leather bracelet for daily wear", null, "Leather Bracelet", 20m, 4 },
                    { 72, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(603), "Customizable laptop sticker for decoration", null, "Laptop Decal Sticker", 7m, 5 },
                    { 73, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(606), "Smooth writing ballpoint pen", null, "Ballpoint Pen", 6m, 3 },
                    { 74, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(609), "Premium noise-cancelling headphones", null, "Noise-Cancelling Headphones", 50m, 2 },
                    { 75, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(613), "Compact Bluetooth speaker for outdoor use", null, "Portable Bluetooth Speaker", 55m, 4 },
                    { 76, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(616), "Eco-friendly reusable water bottle", null, "Reusable Water Bottle", 20m, 5 },
                    { 77, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(619), "Framed wall poster for home decor", null, "Framed Poster", 10m, 1 },
                    { 78, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(622), "Protective silicone phone case", null, "Silicone Phone Case", 15m, 3 },
                    { 79, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(625), "Spacious travel backpack with multiple compartments", null, "Travel Backpack", 30m, 2 },
                    { 80, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(628), "Fitness smartwatch with health tracking features", null, "Smartwatch - Fitness Edition", 80m, 4 },
                    { 81, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(631), "Durable duffel bag for travel", null, "Travel Duffel Bag", 35m, 5 },
                    { 82, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(634), "Slim power bank with fast charging", null, "Portable Power Bank - Slim", 25m, 3 },
                    { 83, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(638), "High-speed USB flash drive with 32GB capacity", null, "High-Speed Flash Drive", 10m, 2 },
                    { 84, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(641), "Compact desktop calendar for office use", null, "Desktop Calendar", 8m, 1 },
                    { 85, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(644), "Comfortable mouse pad with wrist support", null, "Ergonomic Mouse Pad", 12m, 4 },
                    { 86, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(647), "Fast charging USB charger for multiple devices", null, "Fast Charging Charger", 15m, 5 },
                    { 87, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(650), "Durable silicone wristband for everyday wear", null, "Silicone Wristband", 10m, 2 },
                    { 88, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(654), "Quality Syria flag for events", null, "Syria Flag", 9m, 3 },
                    { 89, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(657), "Portable umbrella for travel", null, "Compact Umbrella", 12m, 4 },
                    { 90, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(660), "Small Lebanon flag for personal use", null, "Lebanon Flag - Small", 7m, 5 },
                    { 91, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(663), "Multi-functional desk organizer for office supplies", null, "Office Desk Organizer", 18m, 1 },
                    { 92, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(666), "High-quality art poster for home decor", null, "Art Wall Poster", 9m, 2 },
                    { 93, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(670), "Comfortable Bluetooth over-ear headphones", null, "Bluetooth Over-Ear Headphones", 55m, 3 },
                    { 94, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(712), "Personalized keychain with durable metal", null, "Custom Keychain", 5m, 4 },
                    { 95, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(716), "Luxury smartwatch with premium features", null, "Smartwatch - Luxury Edition", 90m, 5 },
                    { 96, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(719), "Smooth writing rollerball pen", null, "Rollerball Pen", 6m, 2 },
                    { 97, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(722), "Durable academic notebook for school and office", null, "Academic Notebook", 14m, 3 },
                    { 98, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(725), "Breathable summer cap with adjustable strap", null, "Summer Cap", 12m, 4 },
                    { 99, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(728), "Polarized sunglasses with black frame", null, "Polarized Sunglasses - Black", 25m, 1 },
                    { 100, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(732), "Stylish charm bracelet for daily wear", null, "Charm Bracelet", 20m, 3 },
                    { 101, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(735), "Durable protective case for smartphones", null, "Protective Phone Case", 15m, 2 },
                    { 102, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(738), "Spacious and ergonomic travel backpack", null, "Travel Backpack", 32m, 5 },
                    { 103, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(741), "Double-walled insulated water bottle", null, "Insulated Water Bottle", 18m, 4 },
                    { 104, 2, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(744), "Wireless keyboard compatible with all laptops", null, "Wireless Laptop Keyboard", 6m, 1 },
                    { 105, 5, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(748), "High-speed phone charger with universal compatibility", null, "Fast Charging Phone Charger", 16m, 2 },
                    { 106, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(751), "64GB high-speed USB flash drive", null, "USB Flash Drive", 12m, 3 },
                    { 107, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(754), "Elegant leather wristband for men and women", null, "Leather Wristband", 11m, 5 },
                    { 108, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(757), "Stylish desktop calendar with monthly pages", null, "Desktop Calendar", 8m, 4 },
                    { 109, 3, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(760), "Smooth-writing gel ink pen for office use", null, "Gel Ink Pen", 7m, 1 },
                    { 110, 4, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(763), "Lightweight expandable travel bag", null, "Expandable Travel Bag", 36m, 3 },
                    { 111, 1, new DateTime(2024, 10, 15, 17, 15, 24, 56, DateTimeKind.Local).AddTicks(767), "Classic journal notebook for writing and notes", null, "Journal Notebook", 13m, 2 }
                });

            migrationBuilder.InsertData(
                table: "WareHousesProducts",
                columns: new[] { "ProductID", "WareHouseID", "CurrentStock", "MaxStock", "MinStock" },
                values: new object[,]
                {
                    { 1, 3, (short)12, (short)41, (short)7 },
                    { 1, 5, (short)12, (short)41, (short)7 },
                    { 2, 1, (short)5, (short)44, (short)9 },
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
                    { 31, 1, (short)2, (short)37, (short)6 },
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
                    { 43, 5, (short)9, (short)44, (short)10 },
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
                    { 57, 5, (short)7, (short)46, (short)11 },
                    { 58, 3, (short)13, (short)41, (short)9 },
                    { 59, 1, (short)4, (short)36, (short)7 },
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
                    { 76, 3, (short)5, (short)48, (short)13 },
                    { 77, 2, (short)10, (short)36, (short)6 },
                    { 78, 5, (short)10, (short)45, (short)12 },
                    { 79, 1, (short)8, (short)42, (short)9 },
                    { 80, 4, (short)13, (short)41, (short)8 },
                    { 81, 3, (short)10, (short)37, (short)7 },
                    { 82, 2, (short)15, (short)44, (short)11 },
                    { 83, 5, (short)19, (short)48, (short)14 },
                    { 84, 1, (short)9, (short)35, (short)6 },
                    { 85, 4, (short)16, (short)46, (short)12 },
                    { 86, 3, (short)3, (short)42, (short)10 },
                    { 87, 2, (short)11, (short)40, (short)8 },
                    { 88, 5, (short)10, (short)38, (short)7 },
                    { 89, 1, (short)12, (short)43, (short)9 },
                    { 90, 4, (short)15, (short)44, (short)11 },
                    { 91, 3, (short)12, (short)49, (short)13 },
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
                    { 103, 5, (short)10, (short)47, (short)12 },
                    { 104, 1, (short)10, (short)39, (short)7 },
                    { 105, 3, (short)14, (short)42, (short)9 },
                    { 106, 2, (short)11, (short)38, (short)8 },
                    { 107, 4, (short)15, (short)43, (short)10 },
                    { 108, 5, (short)0, (short)46, (short)11 },
                    { 109, 1, (short)12, (short)39, (short)7 },
                    { 110, 2, (short)18, (short)45, (short)12 },
                    { 111, 3, (short)14, (short)42, (short)9 }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "CreateAt", "ItemsSold", "ProductId", "SaleDate", "TotalPrice", "WareHouseId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 15, 17, 15, 24, 61, DateTimeKind.Local).AddTicks(4728), 5, 1, new DateTime(2024, 10, 15, 17, 15, 24, 61, DateTimeKind.Local).AddTicks(5144), 100m, 3 },
                    { 2, new DateTime(2024, 10, 15, 17, 15, 24, 61, DateTimeKind.Local).AddTicks(6603), 10, 2, new DateTime(2024, 10, 15, 17, 15, 24, 61, DateTimeKind.Local).AddTicks(6613), 200m, 1 },
                    { 3, new DateTime(2024, 10, 15, 17, 15, 24, 61, DateTimeKind.Local).AddTicks(6634), 15, 3, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 5 },
                    { 4, new DateTime(2024, 10, 15, 17, 15, 24, 61, DateTimeKind.Local).AddTicks(6682), 20, 4, new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 400m, 2 },
                    { 5, new DateTime(2024, 10, 15, 17, 15, 24, 61, DateTimeKind.Local).AddTicks(6703), 25, 5, new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId_WareHouseId",
                table: "Sales",
                columns: new[] { "ProductId", "WareHouseId" });

            migrationBuilder.CreateIndex(
                name: "IX_WareHousesProducts_WareHouseID",
                table: "WareHousesProducts",
                column: "WareHouseID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "WareHousesProducts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "WareHouses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
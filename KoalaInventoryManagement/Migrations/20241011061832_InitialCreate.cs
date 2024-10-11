using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KoalaInventoryManagement.Migrations
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
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CreateAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Phone_Number = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Email_Address = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Rating = table.Column<byte>(type: "INTEGER", nullable: true),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WareHouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreateAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "money", nullable: false),
                    Image = table.Column<byte[]>(type: "BLOB", nullable: true),
                    SupplierId = table.Column<int>(type: "INTEGER", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    WareHouseID = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductID = table.Column<int>(type: "INTEGER", nullable: false),
                    MinStock = table.Column<short>(type: "INTEGER", nullable: false),
                    CurrentStock = table.Column<short>(type: "INTEGER", nullable: false),
                    MaxStock = table.Column<short>(type: "INTEGER", nullable: false)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemsSold = table.Column<int>(type: "INTEGER", nullable: false),
                    SaleDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    WareHouseId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_WareHousesProducts_WareHouseId_ProductId",
                        columns: x => new { x.WareHouseId, x.ProductId },
                        principalTable: "WareHousesProducts",
                        principalColumns: new[] { "ProductID", "WareHouseID" },
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 11, 9, 18, 31, 58, DateTimeKind.Local).AddTicks(313), "Electronics" },
                    { 2, new DateTime(2024, 10, 11, 9, 18, 31, 69, DateTimeKind.Local).AddTicks(4600), "Clothing" },
                    { 3, new DateTime(2024, 10, 11, 9, 18, 31, 69, DateTimeKind.Local).AddTicks(4630), "Groceries" },
                    { 4, new DateTime(2024, 10, 11, 9, 18, 31, 69, DateTimeKind.Local).AddTicks(4634), "Furniture" },
                    { 5, new DateTime(2024, 10, 11, 9, 18, 31, 69, DateTimeKind.Local).AddTicks(4636), "Accessories" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "CreateAt", "Email_Address", "Image", "Name", "Phone_Number", "Rating" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 11, 9, 18, 31, 70, DateTimeKind.Local).AddTicks(4173), "pyramidsmail@pyr.com", null, "Misr Pyramids Group", "01523456789", (byte)7 },
                    { 2, new DateTime(2024, 10, 11, 9, 18, 31, 70, DateTimeKind.Local).AddTicks(5324), "hero@basics.com", null, "Hero Basics", "01283492232", (byte)5 },
                    { 3, new DateTime(2024, 10, 11, 9, 18, 31, 70, DateTimeKind.Local).AddTicks(5338), "Resi@trade.com", null, "Resi Trade", "01129555939", (byte)9 },
                    { 4, new DateTime(2024, 10, 11, 9, 18, 31, 70, DateTimeKind.Local).AddTicks(5342), "Lamar@gmail.com", null, "lamar", "01522233333", (byte)3 },
                    { 5, new DateTime(2024, 10, 11, 9, 18, 31, 70, DateTimeKind.Local).AddTicks(5345), "info@Hazlam.com", null, "Hazlam", "01575732113", (byte)8 }
                });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "Id", "CreateAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 11, 9, 18, 31, 70, DateTimeKind.Local).AddTicks(8563), "Section A" },
                    { 2, new DateTime(2024, 10, 11, 9, 18, 31, 70, DateTimeKind.Local).AddTicks(8917), "Section B" },
                    { 3, new DateTime(2024, 10, 11, 9, 18, 31, 70, DateTimeKind.Local).AddTicks(8928), "Section C" },
                    { 4, new DateTime(2024, 10, 11, 9, 18, 31, 70, DateTimeKind.Local).AddTicks(8931), "Section D" },
                    { 5, new DateTime(2024, 10, 11, 9, 18, 31, 70, DateTimeKind.Local).AddTicks(8934), "Section E" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Description", "Image", "Name", "Price", "SupplierId" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(3486), "Automotive Products", null, "Saudi Arabia Flag", 804.0, 2 },
                    { 2, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(4995), "Toys", null, "Textbook", 394.0, 4 },
                    { 3, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5009), "Home Appliances", null, "Laptop", 740.0, 2 },
                    { 4, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5013), "Beauty Products", null, "TV", 72.0, 5 },
                    { 5, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5016), "Garden Equipment", null, "Saudi Arabia Flag", 490.0, 4 },
                    { 6, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5030), "Furniture", null, "Smartphone", 113.0, 3 },
                    { 7, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5033), "Electronics Products", null, "Sofa", 607.0, 5 },
                    { 8, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5036), "Books", null, "Power Bank", 664.0, 2 },
                    { 9, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5039), "Electronics Products", null, "Camera", 99.0, 1 },
                    { 10, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5044), "Sports Equipment", null, "Dining Table", 833.0, 4 },
                    { 11, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5047), "Flags Products", null, "Palestine Flag", 9.0, 1 },
                    { 12, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5050), "Flags Products", null, "Egypt Flag", 8.0, 2 },
                    { 13, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5053), "Flags Products", null, "Saudi Arabia Flag", 10.0, 3 },
                    { 14, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5056), "Electronics Products", null, "Laptop", 500.0, 1 },
                    { 15, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5059), "Electronics Products", null, "Smartphone", 300.0, 2 },
                    { 16, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5062), "Electronics Products", null, "Tablet", 200.0, 3 },
                    { 17, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5065), "Home Appliances", null, "Refrigerator", 800.0, 4 },
                    { 18, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5069), "Home Appliances", null, "Washing Machine", 600.0, 5 },
                    { 19, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5073), "Home Appliances", null, "Microwave", 150.0, 4 },
                    { 20, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5076), "Furniture", null, "Sofa", 350.0, 1 },
                    { 21, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5079), "Furniture", null, "Dining Table", 450.0, 2 },
                    { 22, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5082), "Furniture", null, "Bed Frame", 400.0, 3 },
                    { 23, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5085), "Books", null, "Novel", 15.0, 1 },
                    { 24, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5088), "Books", null, "Cookbook", 20.0, 2 },
                    { 25, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5091), "Books", null, "Textbook", 30.0, 3 },
                    { 26, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5094), "Furniture", null, "Monitor", 180.0, 2 },
                    { 27, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5097), "Beauty Products", null, "Wardrobe", 615.0, 1 },
                    { 28, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5100), "Toys", null, "Mirror", 563.0, 1 },
                    { 29, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5103), "Electronics Products", null, "Cookbook", 243.0, 3 },
                    { 30, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5106), "Flags Products", null, "Heater", 5.0, 4 },
                    { 31, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5109), "Kitchen Appliances", null, "Rug", 336.0, 2 },
                    { 32, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5112), "Home Appliances", null, "Iron", 874.0, 1 },
                    { 33, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5116), "Games", null, "Textbook", 436.0, 2 },
                    { 34, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5120), "Flags Products", null, "Monitor", 927.0, 3 },
                    { 35, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5123), "Musical Instruments", null, "Sofa", 201.0, 5 },
                    { 36, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5126), "Musical Instruments", null, "Cookbook", 399.0, 4 },
                    { 37, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5129), "Kitchen Appliances", null, "Egypt Flag", 549.0, 2 },
                    { 38, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5132), "Toys", null, "Laptop", 442.0, 3 },
                    { 39, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5135), "Books", null, "Bed Frame", 657.0, 5 },
                    { 40, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5138), "Electronics Products", null, "Charger", 257.0, 3 },
                    { 41, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5141), "Automotive Products", null, "Tablet", 639.0, 4 },
                    { 42, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5144), "Home Appliances", null, "Headphones", 676.0, 5 },
                    { 43, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5147), "Flags Products", null, "Dining Table", 161.0, 1 },
                    { 44, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5222), "Flags Products", null, "Palestine Flag", 9.0, 1 },
                    { 45, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5227), "Flags Products", null, "Lebanon Flag", 10.0, 2 },
                    { 46, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5230), "Flags Products", null, "USA Flag", 12.0, 3 },
                    { 47, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5233), "Flags Products", null, "China Flag", 8.0, 4 },
                    { 48, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5236), "Flags Products", null, "Brazil Flag", 11.0, 5 },
                    { 49, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5239), "Flags Products", null, "Germany Flag", 10.0, 1 },
                    { 50, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5243), "Flags Products", null, "France Flag", 9.0, 2 },
                    { 51, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5246), "Flags Products", null, "UK Flag", 13.0, 3 },
                    { 52, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5249), "Flags Products", null, "Russia Flag", 9.0, 4 },
                    { 53, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5252), "Flags Products", null, "Italy Flag", 10.0, 5 },
                    { 54, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5255), "Tech Gadgets", null, "Flash Drive", 50.0, 3 },
                    { 55, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5258), "Stationery", null, "Notebook", 12.0, 1 },
                    { 56, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5261), "Fashion Accessories", null, "Wristband", 20.0, 4 },
                    { 57, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5264), "Flags Products", null, "Palestine Flag", 9.0, 2 },
                    { 58, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5267), "Tech Gadgets", null, "Portable Speaker", 40.0, 5 },
                    { 59, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5271), "Office Supplies", null, "Calendar", 18.0, 3 },
                    { 60, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5274), "Electronics", null, "Headphones", 65.0, 2 },
                    { 61, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5277), "Clothing and Apparel", null, "Cap", 15.0, 1 },
                    { 62, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5280), "Travel Essentials", null, "Water Bottle", 25.0, 4 },
                    { 63, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5283), "Home Decor", null, "Poster", 8.0, 2 },
                    { 64, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5286), "Flags Products", null, "Palestine Flag", 10.0, 2 },
                    { 65, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5289), "Office Supplies", null, "Coffee Mug", 15.0, 4 },
                    { 66, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5294), "Flags Products", null, "Jordan Flag", 8.0, 1 },
                    { 67, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5297), "Fashion Accessories", null, "Keychain", 5.0, 3 },
                    { 68, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5300), "Fashion Accessories", null, "Sunglasses", 25.0, 5 },
                    { 69, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5303), "Clothing and Apparel", null, "T-shirt", 18.0, 2 },
                    { 70, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5306), "Stationery", null, "Notebook", 12.0, 1 },
                    { 71, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5309), "Fashion Accessories", null, "Bracelet", 20.0, 4 },
                    { 72, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5313), "Stationery", null, "Laptop Sticker", 7.0, 5 },
                    { 73, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5316), "Office Supplies", null, "Pen", 6.0, 3 },
                    { 74, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5319), "Tech Gadgets", null, "Headphones", 50.0, 2 },
                    { 75, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5322), "Tech Gadgets", null, "Portable Speaker", 55.0, 4 },
                    { 76, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5325), "Travel Essentials", null, "Water Bottle", 20.0, 5 },
                    { 77, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5328), "Home Decor", null, "Poster", 10.0, 1 },
                    { 78, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5331), "Tech Gadgets", null, "Phone Case", 15.0, 3 },
                    { 79, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5334), "Travel Essentials", null, "Backpack", 30.0, 2 },
                    { 80, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5337), "Tech Gadgets", null, "Smartwatch", 80.0, 4 },
                    { 81, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5340), "Travel Essentials", null, "Travel Bag", 35.0, 5 },
                    { 82, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5343), "Tech Gadgets", null, "Power Bank", 25.0, 3 },
                    { 83, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5346), "Tech Gadgets", null, "Flash Drive", 10.0, 2 },
                    { 84, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5349), "Office Supplies", null, "Calendar", 8.0, 1 },
                    { 85, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5352), "Office Supplies", null, "Mouse Pad", 12.0, 4 },
                    { 86, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5355), "Tech Gadgets", null, "Charger", 15.0, 5 },
                    { 87, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5358), "Fashion Accessories", null, "Wristband", 10.0, 2 },
                    { 88, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5361), "Flags Products", null, "Syria Flag", 9.0, 3 },
                    { 89, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5364), "Travel Essentials", null, "Umbrella", 12.0, 4 },
                    { 90, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5367), "Flags Products", null, "Lebanon Flag", 7.0, 5 },
                    { 91, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5371), "Office Supplies", null, "Desk Organizer", 18.0, 1 },
                    { 92, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5374), "Home Decor", null, "Poster", 9.0, 2 },
                    { 93, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5377), "Tech Gadgets", null, "Headphones", 55.0, 3 },
                    { 94, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5380), "Fashion Accessories", null, "Keychain", 5.0, 4 },
                    { 95, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5383), "Tech Gadgets", null, "Smartwatch", 90.0, 5 },
                    { 96, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5386), "Office Supplies", null, "Pen", 6.0, 2 },
                    { 97, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5425), "Stationery", null, "Notebook", 14.0, 3 },
                    { 98, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5429), "Clothing and Apparel", null, "Cap", 12.0, 4 },
                    { 99, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5432), "Fashion Accessories", null, "Sunglasses", 25.0, 1 },
                    { 100, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5435), "Fashion Accessories", null, "Bracelet", 20.0, 3 },
                    { 101, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5438), "Tech Gadgets", null, "Phone Case", 15.0, 2 },
                    { 102, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5441), "Travel Essentials", null, "Backpack", 32.0, 5 },
                    { 103, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5444), "Travel Essentials", null, "Water Bottle", 18.0, 4 },
                    { 104, 2, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5447), "Stationery", null, "Laptop Sticker", 6.0, 1 },
                    { 105, 5, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5450), "Tech Gadgets", null, "Charger", 16.0, 2 },
                    { 106, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5453), "Tech Gadgets", null, "Flash Drive", 12.0, 3 },
                    { 107, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5456), "Fashion Accessories", null, "Wristband", 11.0, 5 },
                    { 108, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5459), "Office Supplies", null, "Calendar", 8.0, 4 },
                    { 109, 3, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5462), "Office Supplies", null, "Pen", 7.0, 1 },
                    { 110, 4, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5465), "Travel Essentials", null, "Travel Bag", 36.0, 3 },
                    { 111, 1, new DateTime(2024, 10, 11, 9, 18, 31, 76, DateTimeKind.Local).AddTicks(5468), "Stationery", null, "Notebook", 13.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "WareHousesProducts",
                columns: new[] { "ProductID", "WareHouseID", "CurrentStock", "MaxStock", "MinStock" },
                values: new object[,]
                {
                    { 1, 4, (short)12, (short)41, (short)7 },
                    { 2, 1, (short)18, (short)44, (short)9 },
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_WareHouseId_ProductId",
                table: "Sales",
                columns: new[] { "WareHouseId", "ProductId" });

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

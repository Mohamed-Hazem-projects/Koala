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
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 13, 15, 19, 41, 755, DateTimeKind.Local).AddTicks(5847), "Electronics" },
                    { 2, new DateTime(2024, 10, 13, 15, 19, 41, 769, DateTimeKind.Local).AddTicks(6577), "Clothing" },
                    { 3, new DateTime(2024, 10, 13, 15, 19, 41, 769, DateTimeKind.Local).AddTicks(6633), "Groceries" },
                    { 4, new DateTime(2024, 10, 13, 15, 19, 41, 769, DateTimeKind.Local).AddTicks(6638), "Furniture" },
                    { 5, new DateTime(2024, 10, 13, 15, 19, 41, 769, DateTimeKind.Local).AddTicks(6641), "Accessories" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "CreateAt", "Email_Address", "Image", "Name", "Phone_Number", "Rating" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 13, 15, 19, 41, 771, DateTimeKind.Local).AddTicks(4303), "pyramidsmail@pyr.com", null, "Misr Pyramids Group", "01523456789", (byte)7 },
                    { 2, new DateTime(2024, 10, 13, 15, 19, 41, 771, DateTimeKind.Local).AddTicks(6426), "hero@basics.com", null, "Hero Basics", "01283492232", (byte)5 },
                    { 3, new DateTime(2024, 10, 13, 15, 19, 41, 771, DateTimeKind.Local).AddTicks(6472), "Resi@trade.com", null, "Resi Trade", "01129555939", (byte)9 },
                    { 4, new DateTime(2024, 10, 13, 15, 19, 41, 771, DateTimeKind.Local).AddTicks(6477), "Lamar@gmail.com", null, "lamar", "01522233333", (byte)3 },
                    { 5, new DateTime(2024, 10, 13, 15, 19, 41, 771, DateTimeKind.Local).AddTicks(6482), "info@Hazlam.com", null, "Hazlam", "01575732113", (byte)8 }
                });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "Id", "CreateAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 13, 15, 19, 41, 772, DateTimeKind.Local).AddTicks(2148), "Section A" },
                    { 2, new DateTime(2024, 10, 13, 15, 19, 41, 772, DateTimeKind.Local).AddTicks(2713), "Section B" },
                    { 3, new DateTime(2024, 10, 13, 15, 19, 41, 772, DateTimeKind.Local).AddTicks(2731), "Section C" },
                    { 4, new DateTime(2024, 10, 13, 15, 19, 41, 772, DateTimeKind.Local).AddTicks(2736), "Section D" },
                    { 5, new DateTime(2024, 10, 13, 15, 19, 41, 772, DateTimeKind.Local).AddTicks(2741), "Section E" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Description", "Image", "Name", "Price", "SupplierId" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(5562), "Automotive Products", null, "Saudi Arabia Flag", 804m, 2 },
                    { 2, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7444), "Toys", null, "Textbook", 394m, 4 },
                    { 3, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7463), "Home Appliances", null, "Laptop", 740m, 2 },
                    { 4, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7467), "Beauty Products", null, "TV", 72m, 5 },
                    { 5, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7471), "Garden Equipment", null, "Saudi Arabia Flag", 490m, 4 },
                    { 6, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7486), "Furniture", null, "Smartphone", 113m, 3 },
                    { 7, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7491), "Electronics Products", null, "Sofa", 607m, 5 },
                    { 8, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7494), "Books", null, "Power Bank", 664m, 2 },
                    { 9, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7498), "Electronics Products", null, "Camera", 99m, 1 },
                    { 10, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7503), "Sports Equipment", null, "Dining Table", 833m, 4 },
                    { 11, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7507), "Flags Products", null, "Palestine Flag", 9m, 1 },
                    { 12, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7511), "Flags Products", null, "Egypt Flag", 8m, 2 },
                    { 13, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7514), "Flags Products", null, "Saudi Arabia Flag", 10m, 3 },
                    { 14, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7518), "Electronics Products", null, "Laptop", 500m, 1 },
                    { 15, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7627), "Electronics Products", null, "Smartphone", 300m, 2 },
                    { 16, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7632), "Electronics Products", null, "Tablet", 200m, 3 },
                    { 17, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7635), "Home Appliances", null, "Refrigerator", 800m, 4 },
                    { 18, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7641), "Home Appliances", null, "Washing Machine", 600m, 5 },
                    { 19, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7645), "Home Appliances", null, "Microwave", 150m, 4 },
                    { 20, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7649), "Furniture", null, "Sofa", 350m, 1 },
                    { 21, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7652), "Furniture", null, "Dining Table", 450m, 2 },
                    { 22, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7656), "Furniture", null, "Bed Frame", 400m, 3 },
                    { 23, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7661), "Books", null, "Novel", 15m, 1 },
                    { 24, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7664), "Books", null, "Cookbook", 20m, 2 },
                    { 25, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7668), "Books", null, "Textbook", 30m, 3 },
                    { 26, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7671), "Furniture", null, "Monitor", 180m, 2 },
                    { 27, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7675), "Beauty Products", null, "Wardrobe", 615m, 1 },
                    { 28, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7678), "Toys", null, "Mirror", 563m, 1 },
                    { 29, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7682), "Electronics Products", null, "Cookbook", 243m, 3 },
                    { 30, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7685), "Flags Products", null, "Heater", 5m, 4 },
                    { 31, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7689), "Kitchen Appliances", null, "Rug", 336m, 2 },
                    { 32, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7692), "Home Appliances", null, "Iron", 874m, 1 },
                    { 33, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7696), "Games", null, "Textbook", 436m, 2 },
                    { 34, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7701), "Flags Products", null, "Monitor", 927m, 3 },
                    { 35, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7704), "Musical Instruments", null, "Sofa", 201m, 5 },
                    { 36, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7708), "Musical Instruments", null, "Cookbook", 399m, 4 },
                    { 37, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7711), "Kitchen Appliances", null, "Egypt Flag", 549m, 2 },
                    { 38, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7715), "Toys", null, "Laptop", 442m, 3 },
                    { 39, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7718), "Books", null, "Bed Frame", 657m, 5 },
                    { 40, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7722), "Electronics Products", null, "Charger", 257m, 3 },
                    { 41, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7726), "Automotive Products", null, "Tablet", 639m, 4 },
                    { 42, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7729), "Home Appliances", null, "Headphones", 676m, 5 },
                    { 43, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7733), "Flags Products", null, "Dining Table", 161m, 1 },
                    { 44, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7736), "Flags Products", null, "Palestine Flag", 9m, 1 },
                    { 45, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7740), "Flags Products", null, "Lebanon Flag", 10m, 2 },
                    { 46, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7743), "Flags Products", null, "USA Flag", 12m, 3 },
                    { 47, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7747), "Flags Products", null, "China Flag", 8m, 4 },
                    { 48, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7751), "Flags Products", null, "Brazil Flag", 11m, 5 },
                    { 49, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7754), "Flags Products", null, "Germany Flag", 10m, 1 },
                    { 50, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7758), "Flags Products", null, "France Flag", 9m, 2 },
                    { 51, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7761), "Flags Products", null, "UK Flag", 13m, 3 },
                    { 52, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7764), "Flags Products", null, "Russia Flag", 9m, 4 },
                    { 53, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7768), "Flags Products", null, "Italy Flag", 10m, 5 },
                    { 54, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7771), "Tech Gadgets", null, "Flash Drive", 50m, 3 },
                    { 55, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7775), "Stationery", null, "Notebook", 12m, 1 },
                    { 56, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7779), "Fashion Accessories", null, "Wristband", 20m, 4 },
                    { 57, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7783), "Flags Products", null, "Palestine Flag", 9m, 2 },
                    { 58, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7786), "Tech Gadgets", null, "Portable Speaker", 40m, 5 },
                    { 59, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7790), "Office Supplies", null, "Calendar", 18m, 3 },
                    { 60, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7793), "Electronics", null, "Headphones", 65m, 2 },
                    { 61, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7797), "Clothing and Apparel", null, "Cap", 15m, 1 },
                    { 62, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7800), "Travel Essentials", null, "Water Bottle", 25m, 4 },
                    { 63, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7804), "Home Decor", null, "Poster", 8m, 2 },
                    { 64, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7807), "Flags Products", null, "Palestine Flag", 10m, 2 },
                    { 65, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7811), "Office Supplies", null, "Coffee Mug", 15m, 4 },
                    { 66, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7860), "Flags Products", null, "Jordan Flag", 8m, 1 },
                    { 67, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7864), "Fashion Accessories", null, "Keychain", 5m, 3 },
                    { 68, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7868), "Fashion Accessories", null, "Sunglasses", 25m, 5 },
                    { 69, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7871), "Clothing and Apparel", null, "T-shirt", 18m, 2 },
                    { 70, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7875), "Stationery", null, "Notebook", 12m, 1 },
                    { 71, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7878), "Fashion Accessories", null, "Bracelet", 20m, 4 },
                    { 72, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7882), "Stationery", null, "Laptop Sticker", 7m, 5 },
                    { 73, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7886), "Office Supplies", null, "Pen", 6m, 3 },
                    { 74, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7889), "Tech Gadgets", null, "Headphones", 50m, 2 },
                    { 75, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7893), "Tech Gadgets", null, "Portable Speaker", 55m, 4 },
                    { 76, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7896), "Travel Essentials", null, "Water Bottle", 20m, 5 },
                    { 77, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7900), "Home Decor", null, "Poster", 10m, 1 },
                    { 78, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7904), "Tech Gadgets", null, "Phone Case", 15m, 3 },
                    { 79, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7907), "Travel Essentials", null, "Backpack", 30m, 2 },
                    { 80, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7911), "Tech Gadgets", null, "Smartwatch", 80m, 4 },
                    { 81, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7914), "Travel Essentials", null, "Travel Bag", 35m, 5 },
                    { 82, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7917), "Tech Gadgets", null, "Power Bank", 25m, 3 },
                    { 83, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7921), "Tech Gadgets", null, "Flash Drive", 10m, 2 },
                    { 84, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7924), "Office Supplies", null, "Calendar", 8m, 1 },
                    { 85, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7928), "Office Supplies", null, "Mouse Pad", 12m, 4 },
                    { 86, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7931), "Tech Gadgets", null, "Charger", 15m, 5 },
                    { 87, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7935), "Fashion Accessories", null, "Wristband", 10m, 2 },
                    { 88, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7939), "Flags Products", null, "Syria Flag", 9m, 3 },
                    { 89, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7943), "Travel Essentials", null, "Umbrella", 12m, 4 },
                    { 90, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7947), "Flags Products", null, "Lebanon Flag", 7m, 5 },
                    { 91, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7950), "Office Supplies", null, "Desk Organizer", 18m, 1 },
                    { 92, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7954), "Home Decor", null, "Poster", 9m, 2 },
                    { 93, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7958), "Tech Gadgets", null, "Headphones", 55m, 3 },
                    { 94, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7962), "Fashion Accessories", null, "Keychain", 5m, 4 },
                    { 95, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7966), "Tech Gadgets", null, "Smartwatch", 90m, 5 },
                    { 96, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7969), "Office Supplies", null, "Pen", 6m, 2 },
                    { 97, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7973), "Stationery", null, "Notebook", 14m, 3 },
                    { 98, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7976), "Clothing and Apparel", null, "Cap", 12m, 4 },
                    { 99, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7979), "Fashion Accessories", null, "Sunglasses", 25m, 1 },
                    { 100, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7983), "Fashion Accessories", null, "Bracelet", 20m, 3 },
                    { 101, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7986), "Tech Gadgets", null, "Phone Case", 15m, 2 },
                    { 102, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7990), "Travel Essentials", null, "Backpack", 32m, 5 },
                    { 103, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7993), "Travel Essentials", null, "Water Bottle", 18m, 4 },
                    { 104, 2, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(7997), "Stationery", null, "Laptop Sticker", 6m, 1 },
                    { 105, 5, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(8000), "Tech Gadgets", null, "Charger", 16m, 2 },
                    { 106, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(8004), "Tech Gadgets", null, "Flash Drive", 12m, 3 },
                    { 107, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(8008), "Fashion Accessories", null, "Wristband", 11m, 5 },
                    { 108, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(8011), "Office Supplies", null, "Calendar", 8m, 4 },
                    { 109, 3, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(8015), "Office Supplies", null, "Pen", 7m, 1 },
                    { 110, 4, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(8018), "Travel Essentials", null, "Travel Bag", 36m, 3 },
                    { 111, 1, new DateTime(2024, 10, 13, 15, 19, 41, 781, DateTimeKind.Local).AddTicks(8022), "Stationery", null, "Notebook", 13m, 2 }
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

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "CreateAt", "ItemsSold", "ProductId", "SaleDate", "TotalPrice", "WareHouseId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 13, 15, 19, 41, 787, DateTimeKind.Local).AddTicks(364), 5, 1, new DateTime(2024, 10, 13, 15, 19, 41, 787, DateTimeKind.Local).AddTicks(713), 100m, 4 },
                    { 2, new DateTime(2024, 10, 13, 15, 19, 41, 787, DateTimeKind.Local).AddTicks(1934), 10, 2, new DateTime(2024, 10, 13, 15, 19, 41, 787, DateTimeKind.Local).AddTicks(1938), 200m, 1 },
                    { 3, new DateTime(2024, 10, 13, 15, 19, 41, 787, DateTimeKind.Local).AddTicks(1944), 15, 3, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 5 },
                    { 4, new DateTime(2024, 10, 13, 15, 19, 41, 787, DateTimeKind.Local).AddTicks(1989), 20, 4, new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 400m, 2 },
                    { 5, new DateTime(2024, 10, 13, 15, 19, 41, 787, DateTimeKind.Local).AddTicks(1995), 25, 5, new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, 3 }
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

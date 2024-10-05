using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedWareHousesAndProductsTablesWithRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 2, 15, 35, 104, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 2, 15, 35, 109, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 2, 15, 35, 109, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 2, 15, 35, 109, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 2, 15, 35, 109, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateAt", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 5, 2, 15, 35, 112, DateTimeKind.Local).AddTicks(4277), "Flags Products", null, "Palestine Flag", 9m },
                    { 2, new DateTime(2024, 10, 5, 2, 15, 35, 112, DateTimeKind.Local).AddTicks(6074), "Guns Products", null, "Gun AK-74", 1000m },
                    { 3, new DateTime(2024, 10, 5, 2, 15, 35, 112, DateTimeKind.Local).AddTicks(6101), "Food Products", null, "زبادي", 3m }
                });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 2, 15, 35, 110, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 2, 15, 35, 111, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 2, 15, 35, 111, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 2, 15, 35, 111, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "Id", "CreateAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 5, 2, 15, 35, 111, DateTimeKind.Local).AddTicks(7723), "Section A" },
                    { 2, new DateTime(2024, 10, 5, 2, 15, 35, 111, DateTimeKind.Local).AddTicks(8813), "Section B" },
                    { 3, new DateTime(2024, 10, 5, 2, 15, 35, 111, DateTimeKind.Local).AddTicks(8840), "Section C" }
                });

            migrationBuilder.InsertData(
                table: "WareHousesProducts",
                columns: new[] { "ProductID", "WareHouseID", "CurrentStock", "MaxStock", "MinStock" },
                values: new object[,]
                {
                    { 1, 1, (short)20, (short)50, (short)10 },
                    { 1, 2, (short)15, (short)40, (short)5 },
                    { 2, 1, (short)8, (short)25, (short)3 },
                    { 2, 3, (short)12, (short)30, (short)7 },
                    { 3, 2, (short)5, (short)10, (short)4 },
                    { 3, 3, (short)20, (short)50, (short)15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WareHousesProducts_WareHouseID",
                table: "WareHousesProducts",
                column: "WareHouseID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WareHousesProducts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "WareHouses");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 1, 49, 19, 881, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 1, 49, 19, 885, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 1, 49, 19, 885, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 1, 49, 19, 885, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 1, 49, 19, 885, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 1, 49, 19, 887, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 1, 49, 19, 887, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 1, 49, 19, 887, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 5, 1, 49, 19, 887, DateTimeKind.Local).AddTicks(9646));
        }
    }
}

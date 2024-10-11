using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KoalaInventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddSalesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "CreateAt", "ItemsSold", "ProductId", "SaleDate", "TotalPrice", "WareHouseId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 11, 9, 20, 23, 953, DateTimeKind.Local).AddTicks(9542), 5, 1, new DateTime(2024, 10, 11, 9, 20, 23, 953, DateTimeKind.Local).AddTicks(9823), 100m, 4 },
                    { 2, new DateTime(2024, 10, 11, 9, 20, 23, 954, DateTimeKind.Local).AddTicks(1079), 10, 2, new DateTime(2024, 10, 11, 9, 20, 23, 954, DateTimeKind.Local).AddTicks(1090), 200m, 1 },
                    { 3, new DateTime(2024, 10, 11, 9, 20, 23, 954, DateTimeKind.Local).AddTicks(1094), 15, 3, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 5 },
                    { 4, new DateTime(2024, 10, 11, 9, 20, 23, 954, DateTimeKind.Local).AddTicks(1121), 20, 4, new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 400m, 2 },
                    { 5, new DateTime(2024, 10, 11, 9, 20, 23, 954, DateTimeKind.Local).AddTicks(1125), 25, 5, new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, 3 }
                });

        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {


        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "ManagerWH", "MANAGERWH" },
                    { "3", null, "Staff", "STAFF" },
                    { "4", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 12, 46, 44, 428, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 12, 46, 44, 434, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 12, 46, 44, 434, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 12, 46, 44, 434, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 12, 46, 44, 434, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 12, 46, 44, 438, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 12, 46, 44, 439, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 12, 46, 44, 439, DateTimeKind.Local).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 12, 46, 44, 436, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 12, 46, 44, 437, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 12, 46, 44, 437, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 12, 46, 44, 437, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 12, 46, 44, 437, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 12, 46, 44, 438, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 12, 46, 44, 438, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 9, 12, 46, 44, 438, DateTimeKind.Local).AddTicks(1390));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 7, 16, 2, 13, 541, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 7, 16, 2, 13, 547, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 7, 16, 2, 13, 547, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 7, 16, 2, 13, 547, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 7, 16, 2, 13, 547, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 7, 16, 2, 13, 551, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 7, 16, 2, 13, 552, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 7, 16, 2, 13, 552, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 7, 16, 2, 13, 550, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 7, 16, 2, 13, 550, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 7, 16, 2, 13, 550, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 7, 16, 2, 13, 550, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 7, 16, 2, 13, 550, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 7, 16, 2, 13, 551, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 7, 16, 2, 13, 551, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 7, 16, 2, 13, 551, DateTimeKind.Local).AddTicks(2748));
        }
    }
}

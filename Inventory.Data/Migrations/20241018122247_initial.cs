using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "025a08a7-5eba-4cd3-b1ca-d756706f898d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "211bec13-f1e4-41db-abbd-06400fcb2ac6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36f4f5ee-0c3f-4e94-b4e9-d84f2acd09f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42624cb0-4c5b-4f19-b592-531de7c64229");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b68ea4d-1d2d-4660-8325-738a9465e12e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad271e86-7245-437e-97e4-2ca5b6ff6113");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b55921ae-cf9a-4fcf-95f3-0f9e8a4bdb71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdb00e68-c10a-4d51-8c9d-997b1aaa075d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "176be637-5d89-42bb-9f25-f2e690aa9aaf", null, "User", "USER" },
                    { "2d2f7fcb-1a8d-4fe2-af43-2cb530200395", null, "WHManager3", "WHMANAGER3" },
                    { "65c92ea1-a058-47d3-a754-b60ab1fc4f55", null, "Staff", "STAFF" },
                    { "68c016ad-6969-44d9-9395-bdfe5bb9539e", null, "WHManager2", "WHMANAGER2" },
                    { "691e0cef-6c6b-4792-8246-91a3905330dd", null, "WHManager1", "WHMANAGER1" },
                    { "6e8746cd-b013-4e1b-935d-74095011756d", null, "Admin", "ADMIN" },
                    { "7de5ad14-88c1-4c04-8518-b392ee05fb47", null, "WHManager5", "WHMANAGER5" },
                    { "7df38b74-6b3b-4fd5-ae01-34c841058e39", null, "WHManager4", "WHMANAGER4" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a99536c0-0a44-423f-97e8-4589a2bd73e2", 0, "6d9b22db-2b1d-4f54-a1c4-df207d8f3d10", "admin@yourdomain.com", true, "Admin", "User", false, null, "ADMIN@YOURDOMAIN.COM", "ADMIN@YOURDOMAIN.COM", "AQAAAAIAAYagAAAAECbF2ZG/zzd5HBQyfuf2DroL6++cEebAu+trgd6+UbmeVwIBaBMIq1d2WUbAc21Okw==", null, false, "", false, "admin@yourdomain.com" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 173, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 175, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 175, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 175, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 175, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 180, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "SaleDate" },
                values: new object[] { new DateTime(2024, 10, 18, 15, 22, 45, 185, DateTimeKind.Local).AddTicks(2942), new DateTime(2024, 10, 18, 15, 22, 45, 185, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "SaleDate" },
                values: new object[] { new DateTime(2024, 10, 18, 15, 22, 45, 185, DateTimeKind.Local).AddTicks(4202), new DateTime(2024, 10, 18, 15, 22, 45, 185, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 185, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 185, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 185, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 175, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 175, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 175, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 175, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 175, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 176, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 176, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 176, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 176, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 15, 22, 45, 176, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6e8746cd-b013-4e1b-935d-74095011756d", "a99536c0-0a44-423f-97e8-4589a2bd73e2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "176be637-5d89-42bb-9f25-f2e690aa9aaf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d2f7fcb-1a8d-4fe2-af43-2cb530200395");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65c92ea1-a058-47d3-a754-b60ab1fc4f55");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68c016ad-6969-44d9-9395-bdfe5bb9539e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "691e0cef-6c6b-4792-8246-91a3905330dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7de5ad14-88c1-4c04-8518-b392ee05fb47");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7df38b74-6b3b-4fd5-ae01-34c841058e39");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6e8746cd-b013-4e1b-935d-74095011756d", "a99536c0-0a44-423f-97e8-4589a2bd73e2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e8746cd-b013-4e1b-935d-74095011756d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a99536c0-0a44-423f-97e8-4589a2bd73e2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "025a08a7-5eba-4cd3-b1ca-d756706f898d", null, "WHManager1", "WHMANAGER1" },
                    { "211bec13-f1e4-41db-abbd-06400fcb2ac6", null, "User", "USER" },
                    { "36f4f5ee-0c3f-4e94-b4e9-d84f2acd09f2", null, "WHManager5", "WHMANAGER5" },
                    { "42624cb0-4c5b-4f19-b592-531de7c64229", null, "WHManager4", "WHMANAGER4" },
                    { "5b68ea4d-1d2d-4660-8325-738a9465e12e", null, "Staff", "STAFF" },
                    { "ad271e86-7245-437e-97e4-2ca5b6ff6113", null, "WHManager2", "WHMANAGER2" },
                    { "b55921ae-cf9a-4fcf-95f3-0f9e8a4bdb71", null, "Admin", "ADMIN" },
                    { "cdb00e68-c10a-4d51-8c9d-997b1aaa075d", null, "WHManager3", "WHMANAGER3" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 867, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 871, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 871, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 871, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 871, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 884, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 885, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "SaleDate" },
                values: new object[] { new DateTime(2024, 10, 18, 2, 49, 40, 894, DateTimeKind.Local).AddTicks(5656), new DateTime(2024, 10, 18, 2, 49, 40, 894, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "SaleDate" },
                values: new object[] { new DateTime(2024, 10, 18, 2, 49, 40, 894, DateTimeKind.Local).AddTicks(8963), new DateTime(2024, 10, 18, 2, 49, 40, 894, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 894, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 894, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 894, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 873, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 874, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 874, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 874, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 874, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 874, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 874, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 874, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 874, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 18, 2, 49, 40, 874, DateTimeKind.Local).AddTicks(9491));
        }
    }
}

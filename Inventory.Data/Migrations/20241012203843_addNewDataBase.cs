using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory.Data.Migrations
{
    /// <inheritdoc />
    public partial class addNewDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ffce538-2f6e-4e3a-867c-451795456e80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f8dc086-96bc-4e0b-9712-adb434e779ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4becf50-01be-45ee-8214-f3780bfe2d87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2ddd502-5e44-47e6-be88-bb1e227d3925");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9b335bb8-5185-4807-bd32-176d57323b82", null, "Staff", "STAFF" },
                    { "9f767e69-74f9-42d6-ac5f-1230c3ff32c5", null, "Admin", "ADMIN" },
                    { "be52c5a4-5c97-4ec9-8977-0a41b13d7d62", null, "ManagerWH", "MANAGERWH" },
                    { "d60b871d-2a84-4c5e-a0e3-d278e9368984", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 379, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 381, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 381, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 381, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 381, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreateAt", "Name" },
                values: new object[] { new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4949), "Laptop Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 393, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 382, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 382, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 382, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 382, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 382, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 383, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 383, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 383, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 383, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 23, 38, 38, 383, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.InsertData(
                table: "WareHousesProducts",
                columns: new[] { "ProductID", "WareHouseID", "CurrentStock", "MaxStock", "MinStock" },
                values: new object[,]
                {
                    { 1, 2, (short)12, (short)41, (short)7 },
                    { 1, 3, (short)12, (short)41, (short)7 },
                    { 1, 5, (short)12, (short)41, (short)7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b335bb8-5185-4807-bd32-176d57323b82");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f767e69-74f9-42d6-ac5f-1230c3ff32c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be52c5a4-5c97-4ec9-8977-0a41b13d7d62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d60b871d-2a84-4c5e-a0e3-d278e9368984");

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "WareHousesProducts",
                keyColumns: new[] { "ProductID", "WareHouseID" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ffce538-2f6e-4e3a-867c-451795456e80", null, "Staff", "STAFF" },
                    { "2f8dc086-96bc-4e0b-9712-adb434e779ad", null, "Admin", "ADMIN" },
                    { "a4becf50-01be-45ee-8214-f3780bfe2d87", null, "ManagerWH", "MANAGERWH" },
                    { "f2ddd502-5e44-47e6-be88-bb1e227d3925", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 390, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 397, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 397, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 397, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 397, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 410, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreateAt", "Name" },
                values: new object[] { new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1437), "Laptop Sticker" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 411, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 399, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 400, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 400, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 400, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 400, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 400, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 400, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 400, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 400, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "WareHouses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 10, 12, 1, 12, 2, 400, DateTimeKind.Local).AddTicks(9545));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Update4_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Orders",
                newName: "GoodNumber");

            migrationBuilder.RenameColumn(
                name: "NameGood",
                table: "Orders",
                newName: "GoodName");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartReservation",
                value: new DateTime(2023, 10, 17, 12, 44, 4, 775, DateTimeKind.Local).AddTicks(7211));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GoodNumber",
                table: "Orders",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "GoodName",
                table: "Orders",
                newName: "NameGood");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartReservation",
                value: new DateTime(2023, 10, 17, 12, 34, 9, 587, DateTimeKind.Local).AddTicks(4834));
        }
    }
}

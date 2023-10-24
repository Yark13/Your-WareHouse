using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Update3_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentOfmanager",
                table: "Orders",
                newName: "ManagerComment");

            migrationBuilder.RenameColumn(
                name: "CommentOfCustomer",
                table: "Orders",
                newName: "CustomerComment");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndReservation",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OrderStatus",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartReservation",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndReservation",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderStatus",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "StartReservation",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ManagerComment",
                table: "Orders",
                newName: "CommentOfmanager");

            migrationBuilder.RenameColumn(
                name: "CustomerComment",
                table: "Orders",
                newName: "CommentOfCustomer");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Update4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GoodType",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NameGood",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "FirstName", "LastName", "Login", "PasswordHash" },
                values: new object[,]
                {
                    { 1, "Yaroslav", "Melnyk", "Melnyk.Yaroslav56", "a536a8efd05b4dd10a2222adc39ed0e024af8f82f878f6373c8b55dda00b8827" },
                    { 2, "Dmytro", "Ketsyk", "ketsyk.dmytro18", "08684d6dcc3fde3a374d20300263c68181b47c74ce37ce6b93ead884afbb485e" }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "FirstName", "LastName", "Login", "PasswordHash" },
                values: new object[] { 1, "", "", "Manager_001", "78142280e98ac7330281c4eaf10b8a1d919f7893afa3e1f85f9367824e1230fd" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerComment", "CustomerId", "EndReservation", "GoodType", "ManagerComment", "NameGood", "Number", "OrderStatus", "StartReservation" },
                values: new object[,]
                {
                    { 1, null, 2, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 0, null, null, 0, 1, new DateTime(2023, 10, 17, 12, 34, 9, 587, DateTimeKind.Local).AddTicks(4834) },
                    { 2, null, 2, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, "Chair", 100, 2, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, 2, new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, "Sofa", 50, 1, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, 2, new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, null, "Oil", 1000, 1, new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, 2, new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, null, "Weapon", 300, 1, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, 2, new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, "Car", 10, 1, new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "GoodType",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "NameGood",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Orders");
        }
    }
}

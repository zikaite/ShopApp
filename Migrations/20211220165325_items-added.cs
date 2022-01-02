using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopApp.Migrations
{
    public partial class itemsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "ExpiryDate", "Name", "ShopId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 20, 16, 53, 25, 190, DateTimeKind.Utc).AddTicks(6314), "Obuoliai", 0 },
                    { 2, new DateTime(2021, 12, 20, 16, 53, 25, 190, DateTimeKind.Utc).AddTicks(6598), "Sviestas", 0 },
                    { 3, new DateTime(2021, 12, 20, 16, 53, 25, 190, DateTimeKind.Utc).AddTicks(6601), "Miltai", 0 },
                    { 4, new DateTime(2021, 12, 20, 16, 53, 25, 190, DateTimeKind.Utc).AddTicks(6603), "Kiausiniai", 0 },
                    { 5, new DateTime(2021, 12, 20, 16, 53, 25, 190, DateTimeKind.Utc).AddTicks(6605), "Cinamonas", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

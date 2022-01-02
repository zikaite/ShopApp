using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopApp.Migrations
{
    public partial class shopsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpiryDate", "ShopId" },
                values: new object[] { new DateTime(2021, 12, 20, 17, 44, 50, 146, DateTimeKind.Utc).AddTicks(326), 2 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpiryDate", "ShopId" },
                values: new object[] { new DateTime(2021, 12, 20, 17, 44, 50, 146, DateTimeKind.Utc).AddTicks(615), 1 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpiryDate", "ShopId" },
                values: new object[] { new DateTime(2021, 12, 20, 17, 44, 50, 146, DateTimeKind.Utc).AddTicks(617), 1 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpiryDate", "ShopId" },
                values: new object[] { new DateTime(2021, 12, 20, 17, 44, 50, 146, DateTimeKind.Utc).AddTicks(619), 1 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpiryDate", "ShopId" },
                values: new object[] { new DateTime(2021, 12, 20, 17, 44, 50, 146, DateTimeKind.Utc).AddTicks(621), 2 });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Maxima" },
                    { 2, "Lidl" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpiryDate", "ShopId" },
                values: new object[] { new DateTime(2021, 12, 20, 16, 53, 25, 190, DateTimeKind.Utc).AddTicks(6314), 0 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpiryDate", "ShopId" },
                values: new object[] { new DateTime(2021, 12, 20, 16, 53, 25, 190, DateTimeKind.Utc).AddTicks(6598), 0 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpiryDate", "ShopId" },
                values: new object[] { new DateTime(2021, 12, 20, 16, 53, 25, 190, DateTimeKind.Utc).AddTicks(6601), 0 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpiryDate", "ShopId" },
                values: new object[] { new DateTime(2021, 12, 20, 16, 53, 25, 190, DateTimeKind.Utc).AddTicks(6603), 0 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpiryDate", "ShopId" },
                values: new object[] { new DateTime(2021, 12, 20, 16, 53, 25, 190, DateTimeKind.Utc).AddTicks(6605), 0 });
        }
    }
}

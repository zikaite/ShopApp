using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopApp.Migrations
{
    public partial class updatingitemsList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Shops_ShopsListId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ShopsListId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ShopsListId",
                table: "Items");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 27, 15, 17, 58, 362, DateTimeKind.Utc).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 27, 15, 17, 58, 363, DateTimeKind.Utc).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 27, 15, 17, 58, 363, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 27, 15, 17, 58, 363, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 27, 15, 17, 58, 363, DateTimeKind.Utc).AddTicks(41));

            migrationBuilder.CreateIndex(
                name: "IX_Items_ShopId",
                table: "Items",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Shops_ShopId",
                table: "Items",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Shops_ShopId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ShopId",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "ShopsListId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 27, 15, 11, 31, 325, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 27, 15, 11, 31, 325, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 27, 15, 11, 31, 325, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 27, 15, 11, 31, 325, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 27, 15, 11, 31, 325, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.CreateIndex(
                name: "IX_Items_ShopsListId",
                table: "Items",
                column: "ShopsListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Shops_ShopsListId",
                table: "Items",
                column: "ShopsListId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

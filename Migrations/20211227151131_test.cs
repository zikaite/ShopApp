using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopApp.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Shops_ShopsId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "ShopsId",
                table: "Items",
                newName: "ShopsListId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ShopsId",
                table: "Items",
                newName: "IX_Items_ShopsListId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Shops_ShopsListId",
                table: "Items",
                column: "ShopsListId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Shops_ShopsListId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "ShopsListId",
                table: "Items",
                newName: "ShopsId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ShopsListId",
                table: "Items",
                newName: "IX_Items_ShopsId");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 27, 14, 19, 47, 975, DateTimeKind.Utc).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 27, 14, 19, 47, 975, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 27, 14, 19, 47, 975, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 27, 14, 19, 47, 975, DateTimeKind.Utc).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 27, 14, 19, 47, 975, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Shops_ShopsId",
                table: "Items",
                column: "ShopsId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

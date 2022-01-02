using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopApp.Migrations
{
    public partial class testupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsTag_Items_ItemId",
                table: "ItemsTag");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemsTag_ItemsTag_ItemTagTagId_ItemTagItemId",
                table: "ItemsTag");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemsTag_Tags_TagId",
                table: "ItemsTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemsTag",
                table: "ItemsTag");

            migrationBuilder.DropIndex(
                name: "IX_ItemsTag_ItemTagTagId_ItemTagItemId",
                table: "ItemsTag");

            migrationBuilder.DropColumn(
                name: "ItemTagItemId",
                table: "ItemsTag");

            migrationBuilder.DropColumn(
                name: "ItemTagTagId",
                table: "ItemsTag");

            migrationBuilder.RenameTable(
                name: "ItemsTag",
                newName: "ItemTags");

            migrationBuilder.RenameIndex(
                name: "IX_ItemsTag_ItemId",
                table: "ItemTags",
                newName: "IX_ItemTags_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemTags",
                table: "ItemTags",
                columns: new[] { "TagId", "ItemId" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiryDate",
                value: new DateTime(2022, 1, 2, 13, 5, 13, 976, DateTimeKind.Utc).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiryDate",
                value: new DateTime(2022, 1, 2, 13, 5, 13, 976, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpiryDate",
                value: new DateTime(2022, 1, 2, 13, 5, 13, 976, DateTimeKind.Utc).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpiryDate",
                value: new DateTime(2022, 1, 2, 13, 5, 13, 976, DateTimeKind.Utc).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "ExpiryDate",
                value: new DateTime(2022, 1, 2, 13, 5, 13, 976, DateTimeKind.Utc).AddTicks(2297));

            migrationBuilder.AddForeignKey(
                name: "FK_ItemTags_Items_ItemId",
                table: "ItemTags",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemTags_Tags_TagId",
                table: "ItemTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemTags_Items_ItemId",
                table: "ItemTags");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemTags_Tags_TagId",
                table: "ItemTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemTags",
                table: "ItemTags");

            migrationBuilder.RenameTable(
                name: "ItemTags",
                newName: "ItemsTag");

            migrationBuilder.RenameIndex(
                name: "IX_ItemTags_ItemId",
                table: "ItemsTag",
                newName: "IX_ItemsTag_ItemId");

            migrationBuilder.AddColumn<int>(
                name: "ItemTagItemId",
                table: "ItemsTag",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemTagTagId",
                table: "ItemsTag",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemsTag",
                table: "ItemsTag",
                columns: new[] { "TagId", "ItemId" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 29, 17, 20, 45, 732, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 29, 17, 20, 45, 732, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 29, 17, 20, 45, 732, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 29, 17, 20, 45, 732, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                column: "ExpiryDate",
                value: new DateTime(2021, 12, 29, 17, 20, 45, 732, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.CreateIndex(
                name: "IX_ItemsTag_ItemTagTagId_ItemTagItemId",
                table: "ItemsTag",
                columns: new[] { "ItemTagTagId", "ItemTagItemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsTag_Items_ItemId",
                table: "ItemsTag",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsTag_ItemsTag_ItemTagTagId_ItemTagItemId",
                table: "ItemsTag",
                columns: new[] { "ItemTagTagId", "ItemTagItemId" },
                principalTable: "ItemsTag",
                principalColumns: new[] { "TagId", "ItemId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsTag_Tags_TagId",
                table: "ItemsTag",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

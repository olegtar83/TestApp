using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestDAL.Migrations
{
    public partial class Seed34sddds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookOrders_Orders",
                table: "BookOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookTypes",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscOrders_Orders",
                table: "DiscOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Discs_DiscContents",
                table: "Discs");

            migrationBuilder.DropForeignKey(
                name: "FK_Discs_DiscTypes",
                table: "Discs");

            migrationBuilder.InsertData(
                table: "BookTypes",
                columns: new[] { "Id", "BookTypeName" },
                values: new object[,]
                {
                    { 1, "Software" },
                    { 2, "Cooking" },
                    { 3, "Esoterica" }
                });

            migrationBuilder.InsertData(
                table: "DiscContents",
                columns: new[] { "Id", "DiscContentName" },
                values: new object[,]
                {
                    { 1, "Music" },
                    { 2, "Video" },
                    { 3, "Software" }
                });

            migrationBuilder.InsertData(
                table: "DiscTypes",
                columns: new[] { "Id", "DiscTypeName" },
                values: new object[,]
                {
                    { 1, "CD" },
                    { 2, "DVD" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "OrderStatus" },
                values: new object[,]
                {
                    { 1, "New" },
                    { 2, "Pending" },
                    { 3, "Executing" },
                    { 4, "Done" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Barcode", "BookTypeId", "ExtraData", "Name", "PageCount", "Price" },
                values: new object[,]
                {
                    { 1, "00000000-0000-0000-0000-000000000000", 1, "{\"Text\":\"Programming language\",\"Value\":\"C#\"}", "Domain-Driven Design", 123, 12m },
                    { 2, "00000000-0000-0000-0000-000000000000", 1, "{\"Text\":\"Programming language\",\"Value\":\"Java\"}", "Scrum Deveploment", 343, 1442m },
                    { 3, "00000000-0000-0000-0000-000000000000", 1, "{\"Text\":\"Programming language\",\"Value\":\"Haskell\"}", "Software Management", 343, 1442m },
                    { 4, "00000000-0000-0000-0000-000000000000", 2, "{\"Text\":\"Basic ingridient\",\"Value\":\"Applles\"}", "Receipts of pie", 545, 6545m },
                    { 5, "00000000-0000-0000-0000-000000000000", 3, "{\"Text\":\"Age Rectriction\",\"Value\":\"18\"}", "Greate misteries", 545, 6545m },
                    { 6, "00000000-0000-0000-0000-000000000000", 3, "{\"Text\":\"\",\"Value\":\"\"}", "History of esoterica", 545, 6545m }
                });

            migrationBuilder.InsertData(
                table: "Discs",
                columns: new[] { "Id", "DiscContentId", "DiscTypeId", "Name" },
                values: new object[,]
                {
                    { 3, 1, 2, "OOP Principles" },
                    { 1, 1, 1, "Marlyn Manson" },
                    { 2, 1, 2, "RHCP 1996" },
                    { 4, 1, 2, "ACDC" },
                    { 5, 2, 2, "National Geografic" },
                    { 6, 2, 2, "CQRS Principles" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientEmail", "CreateDate", "OrderStatusId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "ooe@error.com", new DateTime(2022, 10, 6, 19, 10, 14, 262, DateTimeKind.Local).AddTicks(5125), 1, null },
                    { 2, "oo1@bugs.com", new DateTime(2022, 10, 6, 19, 10, 14, 263, DateTimeKind.Local).AddTicks(6756), 2, null },
                    { 3, "memory@leaks.com", new DateTime(2022, 10, 6, 19, 10, 14, 263, DateTimeKind.Local).AddTicks(6792), 3, null }
                });

            migrationBuilder.InsertData(
                table: "BookOrders",
                columns: new[] { "Id", "BookId", "OrderId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 3, 1 },
                    { 3, 3, 2 },
                    { 5, 5, 2 },
                    { 4, 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "DiscOrders",
                columns: new[] { "Id", "DiscId", "OrderId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 5, 5, 1 },
                    { 2, 3, 2 },
                    { 4, 3, 2 },
                    { 3, 4, 3 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BookOrders_Orders",
                table: "BookOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookTypes",
                table: "Books",
                column: "BookTypeId",
                principalTable: "BookTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DiscOrders_Orders",
                table: "DiscOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Discs_DiscContents",
                table: "Discs",
                column: "DiscContentId",
                principalTable: "DiscContents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Discs_DiscTypes",
                table: "Discs",
                column: "DiscTypeId",
                principalTable: "DiscTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookOrders_Orders",
                table: "BookOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookTypes",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscOrders_Orders",
                table: "DiscOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Discs_DiscContents",
                table: "Discs");

            migrationBuilder.DropForeignKey(
                name: "FK_Discs_DiscTypes",
                table: "Discs");

            migrationBuilder.DeleteData(
                table: "BookOrders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookOrders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookOrders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookOrders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookOrders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DiscOrders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiscOrders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiscOrders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiscOrders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DiscOrders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Discs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DiscContents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiscTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Discs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Discs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Discs",
                keyColumn: "Id",
                keyValue: 5);

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
                table: "BookTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiscContents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiscContents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiscTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddForeignKey(
                name: "FK_BookOrders_Orders",
                table: "BookOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookTypes",
                table: "Books",
                column: "BookTypeId",
                principalTable: "BookTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DiscOrders_Orders",
                table: "DiscOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Discs_DiscContents",
                table: "Discs",
                column: "DiscContentId",
                principalTable: "DiscContents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Discs_DiscTypes",
                table: "Discs",
                column: "DiscTypeId",
                principalTable: "DiscTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

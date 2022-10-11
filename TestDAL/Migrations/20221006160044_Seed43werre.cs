using Microsoft.EntityFrameworkCore.Migrations;

namespace TestDAL.Migrations
{
    public partial class Seed43werre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrdersStatuses",
                table: "Orders");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrdersStatuses",
                table: "Orders",
                column: "OrderStatusId",
                principalTable: "OrderStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrdersStatuses",
                table: "Orders");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrdersStatuses",
                table: "Orders",
                column: "OrderStatusId",
                principalTable: "OrderStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

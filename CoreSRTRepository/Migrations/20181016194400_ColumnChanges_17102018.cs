using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreSRTRepository.Migrations
{
    public partial class ColumnChanges_17102018 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Customers_ShopIdCustomerId",
                table: "Bills");

            migrationBuilder.RenameColumn(
                name: "ShopIdCustomerId",
                table: "Bills",
                newName: "ShopCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_ShopIdCustomerId",
                table: "Bills",
                newName: "IX_Bills_ShopCustomerId");

            migrationBuilder.RenameColumn(
                name: "SGCT",
                table: "BillingItems",
                newName: "SGST");

            migrationBuilder.AddColumn<int>(
                name: "BillId",
                table: "BillingItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BillingItems_BillId",
                table: "BillingItems",
                column: "BillId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillingItems_Bills_BillId",
                table: "BillingItems",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "BillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Customers_ShopCustomerId",
                table: "Bills",
                column: "ShopCustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillingItems_Bills_BillId",
                table: "BillingItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Customers_ShopCustomerId",
                table: "Bills");

            migrationBuilder.DropIndex(
                name: "IX_BillingItems_BillId",
                table: "BillingItems");

            migrationBuilder.DropColumn(
                name: "BillId",
                table: "BillingItems");

            migrationBuilder.RenameColumn(
                name: "ShopCustomerId",
                table: "Bills",
                newName: "ShopIdCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_ShopCustomerId",
                table: "Bills",
                newName: "IX_Bills_ShopIdCustomerId");

            migrationBuilder.RenameColumn(
                name: "SGST",
                table: "BillingItems",
                newName: "SGCT");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Customers_ShopIdCustomerId",
                table: "Bills",
                column: "ShopIdCustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

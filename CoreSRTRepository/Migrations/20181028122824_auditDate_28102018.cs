using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreSRTRepository.Migrations
{
    public partial class auditDate_28102018 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BillingItmeId",
                table: "BillingItems",
                newName: "BillingItemId");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Bills",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "BillingItems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "BillingAudit",
                columns: table => new
                {
                    BillingAutiId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BillId = table.Column<int>(nullable: false),
                    ShopCustomerId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    TotalQuantity = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false),
                    OutStandingAmount = table.Column<double>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingAudit", x => x.BillingAutiId);
                    table.ForeignKey(
                        name: "FK_BillingAudit_Customers_ShopCustomerId",
                        column: x => x.ShopCustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillingItemAudit",
                columns: table => new
                {
                    BillingItemAuditId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BillingItemId = table.Column<int>(nullable: false),
                    BillId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    OriginalPrice = table.Column<double>(nullable: false),
                    SellingPrice = table.Column<double>(nullable: false),
                    CGST = table.Column<double>(nullable: false),
                    SGST = table.Column<double>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingItemAudit", x => x.BillingItemAuditId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillingAudit_ShopCustomerId",
                table: "BillingAudit",
                column: "ShopCustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillingAudit");

            migrationBuilder.DropTable(
                name: "BillingItemAudit");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "BillingItems");

            migrationBuilder.RenameColumn(
                name: "BillingItemId",
                table: "BillingItems",
                newName: "BillingItmeId");
        }
    }
}

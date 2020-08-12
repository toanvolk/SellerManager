using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SellerManager.Data.Migrations
{
    public partial class initdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<string>(maxLength: 50, nullable: false),
                    IsNotUse = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "PriceList",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsNotUse = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    TimeApply = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CustomerId = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceListDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsNotUse = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(maxLength: 50, nullable: true),
                    PriceListId = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<string>(maxLength: 50, nullable: true),
                    ProductName = table.Column<string>(maxLength: 250, nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceListDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<string>(maxLength: 50, nullable: false),
                    IsNotUse = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: false),
                    ModifyBy = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UnitId = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "PriceList");

            migrationBuilder.DropTable(
                name: "PriceListDetail");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}

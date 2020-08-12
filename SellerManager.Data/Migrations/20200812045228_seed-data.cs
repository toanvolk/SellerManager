using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SellerManager.Data.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "CreateBy", "CreateDate", "Description", "IsNotUse", "ModifyBy", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { "KH0001", null, "admin", new DateTime(2020, 8, 12, 11, 52, 28, 175, DateTimeKind.Local).AddTicks(7668), null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khách hàng A" },
                    { "KH0002", null, "admin", new DateTime(2020, 8, 12, 11, 52, 28, 175, DateTimeKind.Local).AddTicks(7819), null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khách hàng B" },
                    { "KH0003", null, "admin", new DateTime(2020, 8, 12, 11, 52, 28, 175, DateTimeKind.Local).AddTicks(7825), null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khách hàng C" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "CreateBy", "CreateDate", "Description", "IsNotUse", "ModifyBy", "ModifyDate", "Name", "UnitId" },
                values: new object[,]
                {
                    { "SPYT001", "admin", new DateTime(2020, 8, 12, 11, 52, 28, 172, DateTimeKind.Local).AddTicks(9948), null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản phẩm Y tế 001", null },
                    { "SPYT002", "admin", new DateTime(2020, 8, 12, 11, 52, 28, 174, DateTimeKind.Local).AddTicks(1826), null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản phẩm Y tế 002", null },
                    { "SPYT003", "admin", new DateTime(2020, 8, 12, 11, 52, 28, 174, DateTimeKind.Local).AddTicks(1871), null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản phẩm Y tế 003", null },
                    { "SPYT004", "admin", new DateTime(2020, 8, 12, 11, 52, 28, 174, DateTimeKind.Local).AddTicks(1874), null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sản phẩm Y tế 004", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: "KH0001");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: "KH0002");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: "KH0003");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: "SPYT001");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: "SPYT002");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: "SPYT003");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: "SPYT004");
        }
    }
}

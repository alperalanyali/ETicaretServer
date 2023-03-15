using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _15_03_2023_05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductStores_Products_ProductId",
                table: "ProductStores");

            migrationBuilder.DropIndex(
                name: "IX_ProductStores_ProductId",
                table: "ProductStores");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductStores");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStores_QuantityTypeId",
                table: "ProductStores",
                column: "QuantityTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStores_QuantityTypes_QuantityTypeId",
                table: "ProductStores",
                column: "QuantityTypeId",
                principalTable: "QuantityTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductStores_QuantityTypes_QuantityTypeId",
                table: "ProductStores");

            migrationBuilder.DropIndex(
                name: "IX_ProductStores_QuantityTypeId",
                table: "ProductStores");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "ProductStores",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ProductStores_ProductId",
                table: "ProductStores",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStores_Products_ProductId",
                table: "ProductStores",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

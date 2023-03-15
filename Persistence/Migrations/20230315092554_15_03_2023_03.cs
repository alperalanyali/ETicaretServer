using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _15_03_2023_03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ProductStores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProductStores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "ProductStores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductStores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "ProductStores",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "QuantityTypeId",
                table: "ProductStores",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ProductStores_ProductId",
                table: "ProductStores",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductStoreId",
                table: "ProductCategories",
                column: "ProductStoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_ProductStores_ProductStoreId",
                table: "ProductCategories",
                column: "ProductStoreId",
                principalTable: "ProductStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStores_Products_ProductId",
                table: "ProductStores",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_ProductStores_ProductStoreId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStores_Products_ProductId",
                table: "ProductStores");

            migrationBuilder.DropIndex(
                name: "IX_ProductStores_ProductId",
                table: "ProductStores");

            migrationBuilder.DropIndex(
                name: "IX_ProductCategories_ProductStoreId",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ProductStores");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProductStores");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "ProductStores");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductStores");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductStores");

            migrationBuilder.DropColumn(
                name: "QuantityTypeId",
                table: "ProductStores");
        }
    }
}

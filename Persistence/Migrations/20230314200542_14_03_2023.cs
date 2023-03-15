using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _14_03_2023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductStores_Products_ProductId",
                table: "ProductStores");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductStores",
                newName: "QuantityTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductStores_ProductId",
                table: "ProductStores",
                newName: "IX_ProductStores_QuantityTypeId");

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
                name: "ProductStoreId",
                table: "ProductCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductStoreId",
                table: "ProductCategories",
                column: "ProductStoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_ProductStores_ProductStoreId",
                table: "ProductCategories",
                column: "ProductStoreId",
                principalTable: "ProductStores",
                principalColumn: "Id");

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
                name: "FK_ProductCategories_ProductStores_ProductStoreId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStores_QuantityTypes_QuantityTypeId",
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
                name: "ProductStoreId",
                table: "ProductCategories");

            migrationBuilder.RenameColumn(
                name: "QuantityTypeId",
                table: "ProductStores",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductStores_QuantityTypeId",
                table: "ProductStores",
                newName: "IX_ProductStores_ProductId");

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

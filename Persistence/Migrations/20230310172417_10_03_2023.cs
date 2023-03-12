using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _10_03_2023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Products_ProductId",
                table: "BasketItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "OrderItems",
                newName: "ProductStoreId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                newName: "IX_OrderItems_ProductStoreId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "BasketItems",
                newName: "ProductStoreId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItems",
                newName: "IX_BasketItems_ProductStoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_ProductStores_ProductStoreId",
                table: "BasketItems",
                column: "ProductStoreId",
                principalTable: "ProductStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_ProductStores_ProductStoreId",
                table: "OrderItems",
                column: "ProductStoreId",
                principalTable: "ProductStores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_ProductStores_ProductStoreId",
                table: "BasketItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_ProductStores_ProductStoreId",
                table: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "ProductStoreId",
                table: "OrderItems",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_ProductStoreId",
                table: "OrderItems",
                newName: "IX_OrderItems_ProductId");

            migrationBuilder.RenameColumn(
                name: "ProductStoreId",
                table: "BasketItems",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItems_ProductStoreId",
                table: "BasketItems",
                newName: "IX_BasketItems_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Products_ProductId",
                table: "BasketItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

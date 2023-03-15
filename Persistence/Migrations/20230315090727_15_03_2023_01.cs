using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _15_03_2023_01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_ProductStores_ProductStoreId",
                table: "ProductCategories");

            migrationBuilder.DropIndex(
                name: "IX_ProductCategories_ProductStoreId",
                table: "ProductCategories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}

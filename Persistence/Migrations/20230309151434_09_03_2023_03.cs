using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _09_03_2023_03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ProductStores_StoreId",
                table: "ProductStores",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStores_Stores_StoreId",
                table: "ProductStores",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductStores_Stores_StoreId",
                table: "ProductStores");

            migrationBuilder.DropIndex(
                name: "IX_ProductStores_StoreId",
                table: "ProductStores");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _12_03_2023_02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_eCommercePayments",
                table: "eCommercePayments");

            migrationBuilder.RenameTable(
                name: "eCommercePayments",
                newName: "ECommercePayments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ECommercePayments",
                table: "ECommercePayments",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ECommercePayments",
                table: "ECommercePayments");

            migrationBuilder.RenameTable(
                name: "ECommercePayments",
                newName: "eCommercePayments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_eCommercePayments",
                table: "eCommercePayments",
                column: "Id");
        }
    }
}

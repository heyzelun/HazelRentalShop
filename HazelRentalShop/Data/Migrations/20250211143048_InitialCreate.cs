using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HazelRentalShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "RentalDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RentalDetails_CustomerId",
                table: "RentalDetails",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentalDetails_Customers_CustomerId",
                table: "RentalDetails",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentalDetails_Customers_CustomerId",
                table: "RentalDetails");

            migrationBuilder.DropIndex(
                name: "IX_RentalDetails_CustomerId",
                table: "RentalDetails");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "RentalDetails");
        }
    }
}

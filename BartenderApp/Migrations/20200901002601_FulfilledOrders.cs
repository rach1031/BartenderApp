using Microsoft.EntityFrameworkCore.Migrations;

namespace BartenderApp.Migrations
{
    public partial class FulfilledOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Fulfilled",
                table: "Orders",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fulfilled",
                table: "Orders");
        }
    }
}

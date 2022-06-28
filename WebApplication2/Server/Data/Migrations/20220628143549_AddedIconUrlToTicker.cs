using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Server.Data.Migrations
{
    public partial class AddedIconUrlToTicker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "Tickers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "Tickers");
        }
    }
}

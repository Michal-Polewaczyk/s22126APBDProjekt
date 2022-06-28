using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Server.Data.Migrations
{
    public partial class AddColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Tickers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortCode",
                table: "Tickers",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Tickers");

            migrationBuilder.DropColumn(
                name: "ShortCode",
                table: "Tickers");
        }
    }
}

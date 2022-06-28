using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Server.Data.Migrations
{
    public partial class DeltedPhoneNumberInTickers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Tickers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Tickers",
                type: "nvarchar(19)",
                maxLength: 19,
                nullable: false,
                defaultValue: "");
        }
    }
}

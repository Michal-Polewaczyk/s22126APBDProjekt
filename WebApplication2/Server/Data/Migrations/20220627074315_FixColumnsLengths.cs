using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Server.Data.Migrations
{
    public partial class FixColumnsLengths : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Tickers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(17)",
                oldMaxLength: 17);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tickers",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Market",
                table: "Tickers",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Tickers",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tickers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140);

            migrationBuilder.AlterColumn<string>(
                name: "Market",
                table: "Tickers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140);
        }
    }
}

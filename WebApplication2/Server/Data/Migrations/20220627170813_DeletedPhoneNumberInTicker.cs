using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Server.Data.Migrations
{
    public partial class DeletedPhoneNumberInTicker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Tickers");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Tickers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Tickers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Tickers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

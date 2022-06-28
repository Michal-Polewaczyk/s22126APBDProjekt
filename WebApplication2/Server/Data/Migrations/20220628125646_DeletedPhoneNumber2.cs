using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Server.Data.Migrations
{
    public partial class DeletedPhoneNumber2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Tickers",
                type: "nvarchar(19)",
                maxLength: 19,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Tickers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(19)",
                oldMaxLength: 19);
        }
    }
}

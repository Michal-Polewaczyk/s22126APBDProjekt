using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Server.Data.Migrations
{
    public partial class InitDomain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickers",
                columns: table => new
                {
                    IdTicker = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Market = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickers", x => x.IdTicker);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserTicker",
                columns: table => new
                {
                    WatchedTickersIdTicker = table.Column<int>(type: "int", nullable: false),
                    WatchersNavigationId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserTicker", x => new { x.WatchedTickersIdTicker, x.WatchersNavigationId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserTicker_AspNetUsers_WatchersNavigationId",
                        column: x => x.WatchersNavigationId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserTicker_Tickers_WatchedTickersIdTicker",
                        column: x => x.WatchedTickersIdTicker,
                        principalTable: "Tickers",
                        principalColumn: "IdTicker",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DailyOpenCloses",
                columns: table => new
                {
                    IdDailyOpenClose = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTicker = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Open = table.Column<double>(type: "float", nullable: false),
                    High = table.Column<double>(type: "float", nullable: false),
                    Low = table.Column<double>(type: "float", nullable: false),
                    Close = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<double>(type: "float", nullable: false),
                    AfterHours = table.Column<double>(type: "float", nullable: false),
                    PreMarket = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyOpenCloses", x => x.IdDailyOpenClose);
                    table.ForeignKey(
                        name: "FK_DailyOpenCloses_Tickers_IdTicker",
                        column: x => x.IdTicker,
                        principalTable: "Tickers",
                        principalColumn: "IdTicker",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    IdNews = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTicker = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfPublishing = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UrlToArticle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.IdNews);
                    table.ForeignKey(
                        name: "FK_News_Tickers_IdTicker",
                        column: x => x.IdTicker,
                        principalTable: "Tickers",
                        principalColumn: "IdTicker");
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    IdPrice = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTicker = table.Column<int>(type: "int", nullable: false),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.IdPrice);
                    table.ForeignKey(
                        name: "FK_Prices_Tickers_IdTicker",
                        column: x => x.IdTicker,
                        principalTable: "Tickers",
                        principalColumn: "IdTicker",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AggregateResults",
                columns: table => new
                {
                    IdAggregateResult = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPrice = table.Column<int>(type: "int", nullable: false),
                    ClosePriceForTheSymbol = table.Column<double>(type: "float", nullable: false),
                    HighestPriceForTheSymbol = table.Column<double>(type: "float", nullable: false),
                    LowestPriceForTheSymbol = table.Column<double>(type: "float", nullable: false),
                    NumberOfTransactions = table.Column<int>(type: "int", nullable: false),
                    OpenPriceForTheSymbol = table.Column<double>(type: "float", nullable: false),
                    UnixMilisecondTimestamp = table.Column<long>(type: "bigint", nullable: false),
                    TradingVolumeOfTheSymbol = table.Column<double>(type: "float", nullable: false),
                    VolumeWeightedAveragePrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AggregateResults", x => x.IdAggregateResult);
                    table.ForeignKey(
                        name: "FK_AggregateResults_Prices_IdPrice",
                        column: x => x.IdPrice,
                        principalTable: "Prices",
                        principalColumn: "IdPrice",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AggregateResults_IdPrice",
                table: "AggregateResults",
                column: "IdPrice");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserTicker_WatchersNavigationId",
                table: "ApplicationUserTicker",
                column: "WatchersNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyOpenCloses_IdTicker",
                table: "DailyOpenCloses",
                column: "IdTicker");

            migrationBuilder.CreateIndex(
                name: "IX_News_IdTicker",
                table: "News",
                column: "IdTicker");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_IdTicker",
                table: "Prices",
                column: "IdTicker");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AggregateResults");

            migrationBuilder.DropTable(
                name: "ApplicationUserTicker");

            migrationBuilder.DropTable(
                name: "DailyOpenCloses");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "Tickers");
        }
    }
}

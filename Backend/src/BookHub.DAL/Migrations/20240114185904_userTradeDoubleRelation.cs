using Microsoft.EntityFrameworkCore.Migrations;

namespace BookHub.Infrastructure.Migrations
{
    public partial class userTradeDoubleRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trades_AspNetUsers_UserId",
                table: "Trades");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTrades_AspNetUsers_UserId",
                table: "UserTrades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTrades",
                table: "UserTrades");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserTrades",
                newName: "UserForId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Trades",
                newName: "UserForId");

            migrationBuilder.RenameIndex(
                name: "IX_Trades_UserId",
                table: "Trades",
                newName: "IX_Trades_UserForId");

            migrationBuilder.AddColumn<int>(
                name: "UserById",
                table: "UserTrades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserById",
                table: "Trades",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTrades",
                table: "UserTrades",
                columns: new[] { "UserById", "UserForId", "TradeId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserTrades_UserForId",
                table: "UserTrades",
                column: "UserForId");

            migrationBuilder.CreateIndex(
                name: "IX_Trades_UserById",
                table: "Trades",
                column: "UserById");

            migrationBuilder.AddForeignKey(
                name: "FK_Trades_AspNetUsers_UserById",
                table: "Trades",
                column: "UserById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trades_AspNetUsers_UserForId",
                table: "Trades",
                column: "UserForId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTrades_AspNetUsers_UserById",
                table: "UserTrades",
                column: "UserById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTrades_AspNetUsers_UserForId",
                table: "UserTrades",
                column: "UserForId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trades_AspNetUsers_UserById",
                table: "Trades");

            migrationBuilder.DropForeignKey(
                name: "FK_Trades_AspNetUsers_UserForId",
                table: "Trades");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTrades_AspNetUsers_UserById",
                table: "UserTrades");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTrades_AspNetUsers_UserForId",
                table: "UserTrades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTrades",
                table: "UserTrades");

            migrationBuilder.DropIndex(
                name: "IX_UserTrades_UserForId",
                table: "UserTrades");

            migrationBuilder.DropIndex(
                name: "IX_Trades_UserById",
                table: "Trades");

            migrationBuilder.DropColumn(
                name: "UserById",
                table: "UserTrades");

            migrationBuilder.DropColumn(
                name: "UserById",
                table: "Trades");

            migrationBuilder.RenameColumn(
                name: "UserForId",
                table: "UserTrades",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "UserForId",
                table: "Trades",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Trades_UserForId",
                table: "Trades",
                newName: "IX_Trades_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTrades",
                table: "UserTrades",
                columns: new[] { "UserId", "TradeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Trades_AspNetUsers_UserId",
                table: "Trades",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTrades_AspNetUsers_UserId",
                table: "UserTrades",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

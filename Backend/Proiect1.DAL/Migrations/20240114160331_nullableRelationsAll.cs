using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect1.Infrastructure.Migrations
{
    public partial class nullableRelationsAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trades_AspNetUsers_UserId",
                table: "Trades");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Trades",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Trades_AspNetUsers_UserId",
                table: "Trades",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trades_AspNetUsers_UserId",
                table: "Trades");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Trades",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Trades_AspNetUsers_UserId",
                table: "Trades",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

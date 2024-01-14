using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect1.Infrastructure.Migrations
{
    public partial class nullableRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_Meetings_MeetingId",
                table: "Agendas");

            migrationBuilder.DropIndex(
                name: "IX_Agendas_MeetingId",
                table: "Agendas");

            migrationBuilder.AlterColumn<int>(
                name: "AgendaId",
                table: "Meetings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MeetingId",
                table: "Agendas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_MeetingId",
                table: "Agendas",
                column: "MeetingId",
                unique: true,
                filter: "[MeetingId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_Meetings_MeetingId",
                table: "Agendas",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "MeetingId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_Meetings_MeetingId",
                table: "Agendas");

            migrationBuilder.DropIndex(
                name: "IX_Agendas_MeetingId",
                table: "Agendas");

            migrationBuilder.AlterColumn<int>(
                name: "AgendaId",
                table: "Meetings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MeetingId",
                table: "Agendas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_MeetingId",
                table: "Agendas",
                column: "MeetingId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_Meetings_MeetingId",
                table: "Agendas",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "MeetingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace BookHub.Infrastructure.Migrations
{
    public partial class feedbackLogic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FeedbackText",
                table: "Feedbacks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nickname",
                table: "Feedbacks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Feedbacks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeedbackText",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Nickname",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Feedbacks");
        }
    }
}

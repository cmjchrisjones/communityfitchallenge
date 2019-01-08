using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityFitChallenge.Web.Migrations
{
    public partial class AddedFlagForProfileCompletion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "UserProfileIsCompleted",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserProfileIsCompleted",
                table: "AspNetUsers");
        }
    }
}

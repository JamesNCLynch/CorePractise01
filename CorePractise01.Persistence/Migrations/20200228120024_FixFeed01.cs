using Microsoft.EntityFrameworkCore.Migrations;

namespace CorePractise01.Persistence.Migrations
{
    public partial class FixFeed01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feed_AspNetUsers_UserId",
                table: "Feed");

            migrationBuilder.DropIndex(
                name: "IX_Feed_UserId",
                table: "Feed");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Feed");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Feed",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Feed_UserId",
                table: "Feed",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feed_AspNetUsers_UserId",
                table: "Feed",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

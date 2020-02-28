using Microsoft.EntityFrameworkCore.Migrations;

namespace CorePractise01.Persistence.Migrations
{
    public partial class FixFeed02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feed_AspNetUsers_AspNetUserIdId",
                table: "Feed");

            migrationBuilder.DropIndex(
                name: "IX_Feed_AspNetUserIdId",
                table: "Feed");

            migrationBuilder.DropColumn(
                name: "AspNetUserIdId",
                table: "Feed");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Feed",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "AspNetUserIdId",
                table: "Feed",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Feed_AspNetUserIdId",
                table: "Feed",
                column: "AspNetUserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feed_AspNetUsers_AspNetUserIdId",
                table: "Feed",
                column: "AspNetUserIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

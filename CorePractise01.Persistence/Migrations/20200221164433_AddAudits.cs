using Microsoft.EntityFrameworkCore.Migrations;

namespace CorePractise01.Persistence.Migrations
{
    public partial class AddAudits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AspNetUserIdId",
                table: "Feed",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

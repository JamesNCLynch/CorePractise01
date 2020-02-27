using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CorePractise01.Persistence.Migrations
{
    public partial class AddAuditDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Feed",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Feed",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Feed",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Feed",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Feed",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feed_AspNetUsers_UserId",
                table: "Feed");

            migrationBuilder.DropIndex(
                name: "IX_Feed_UserId",
                table: "Feed");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Feed");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Feed");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Feed");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Feed");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Feed");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueueSystem.Domain.Migrations
{
    /// <inheritdoc />
    public partial class userServicesMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Services",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_AppUserId",
                table: "Services",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_AspNetUsers_AppUserId",
                table: "Services",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_AspNetUsers_AppUserId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_AppUserId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Services");
        }
    }
}

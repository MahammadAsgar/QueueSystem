using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueueSystem.Domain.Migrations
{
    /// <inheritdoc />
    public partial class userTiketsMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Queues",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Queues_AppUserId",
                table: "Queues",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Queues_AspNetUsers_AppUserId",
                table: "Queues",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Queues_AspNetUsers_AppUserId",
                table: "Queues");

            migrationBuilder.DropIndex(
                name: "IX_Queues_AppUserId",
                table: "Queues");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Queues");
        }
    }
}

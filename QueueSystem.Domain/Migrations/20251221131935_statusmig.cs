using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QueueSystem.Domain.Migrations
{
    /// <inheritdoc />
    public partial class statusmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2025, 12, 21, 17, 19, 34, 714, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2025, 12, 21, 17, 19, 34, 714, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2025, 12, 21, 17, 19, 34, 714, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDate",
                value: new DateTime(2025, 12, 21, 17, 19, 34, 714, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "AddDate", "DeletedDate", "Title", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 21, 17, 19, 34, 715, DateTimeKind.Local).AddTicks(6892), null, "Waiting", null },
                    { 2, new DateTime(2025, 12, 21, 17, 19, 34, 715, DateTimeKind.Local).AddTicks(6898), null, "Called", null },
                    { 3, new DateTime(2025, 12, 21, 17, 19, 34, 715, DateTimeKind.Local).AddTicks(6899), null, "Serving", null },
                    { 4, new DateTime(2025, 12, 21, 17, 19, 34, 715, DateTimeKind.Local).AddTicks(6901), null, "Cancelled", null },
                    { 5, new DateTime(2025, 12, 21, 17, 19, 34, 715, DateTimeKind.Local).AddTicks(6902), null, "Completed", null },
                    { 6, new DateTime(2025, 12, 21, 17, 19, 34, 715, DateTimeKind.Local).AddTicks(6903), null, "Expired", null },
                    { 7, new DateTime(2025, 12, 21, 17, 19, 34, 715, DateTimeKind.Local).AddTicks(6904), null, "Recalled", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2025, 12, 18, 21, 14, 55, 179, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2025, 12, 18, 21, 14, 55, 179, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2025, 12, 18, 21, 14, 55, 179, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDate",
                value: new DateTime(2025, 12, 18, 21, 14, 55, 179, DateTimeKind.Local).AddTicks(8068));
        }
    }
}

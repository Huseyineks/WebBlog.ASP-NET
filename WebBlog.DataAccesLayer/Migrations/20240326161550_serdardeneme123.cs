using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBlog.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class serdardeneme123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "id",
                keyValue: 1,
                column: "createdAt",
                value: new DateTime(2024, 3, 26, 19, 15, 50, 590, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "id",
                keyValue: 2,
                column: "createdAt",
                value: new DateTime(2024, 3, 26, 19, 15, 50, 590, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 15, 50, 590, DateTimeKind.Local).AddTicks(8701), new DateTime(2024, 3, 26, 19, 15, 50, 590, DateTimeKind.Local).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 15, 50, 590, DateTimeKind.Local).AddTicks(8703), new DateTime(2024, 3, 26, 19, 15, 50, 590, DateTimeKind.Local).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 15, 50, 590, DateTimeKind.Local).AddTicks(8705), new DateTime(2024, 3, 26, 19, 15, 50, 590, DateTimeKind.Local).AddTicks(8704) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "id",
                keyValue: 1,
                column: "createdAt",
                value: new DateTime(2024, 3, 26, 16, 49, 9, 422, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "id",
                keyValue: 2,
                column: "createdAt",
                value: new DateTime(2024, 3, 26, 16, 49, 9, 422, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 16, 49, 9, 422, DateTimeKind.Local).AddTicks(4632), new DateTime(2024, 3, 26, 16, 49, 9, 422, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 16, 49, 9, 422, DateTimeKind.Local).AddTicks(4635), new DateTime(2024, 3, 26, 16, 49, 9, 422, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 16, 49, 9, 422, DateTimeKind.Local).AddTicks(4636), new DateTime(2024, 3, 26, 16, 49, 9, 422, DateTimeKind.Local).AddTicks(4635) });
        }
    }
}

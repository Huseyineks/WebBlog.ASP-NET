using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBlog.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class areyouthere : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "commentAuthor",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "commentAuthor",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "id",
                keyValue: 1,
                column: "createdAt",
                value: new DateTime(2024, 3, 25, 19, 9, 40, 609, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "id",
                keyValue: 2,
                column: "createdAt",
                value: new DateTime(2024, 3, 25, 19, 9, 40, 609, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 25, 19, 9, 40, 609, DateTimeKind.Local).AddTicks(7779), new DateTime(2024, 3, 25, 19, 9, 40, 609, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 25, 19, 9, 40, 609, DateTimeKind.Local).AddTicks(7782), new DateTime(2024, 3, 25, 19, 9, 40, 609, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 25, 19, 9, 40, 609, DateTimeKind.Local).AddTicks(7784), new DateTime(2024, 3, 25, 19, 9, 40, 609, DateTimeKind.Local).AddTicks(7783) });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBlog.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class addingacolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "Author", "createdAt", "updatedAt" },
                values: new object[] { "erhan", new DateTime(2024, 3, 25, 19, 9, 40, 609, DateTimeKind.Local).AddTicks(7779), new DateTime(2024, 3, 25, 19, 9, 40, 609, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "Author", "createdAt", "updatedAt" },
                values: new object[] { "erhan", new DateTime(2024, 3, 25, 19, 9, 40, 609, DateTimeKind.Local).AddTicks(7782), new DateTime(2024, 3, 25, 19, 9, 40, 609, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "Author", "createdAt", "updatedAt" },
                values: new object[] { "erhan", new DateTime(2024, 3, 25, 19, 9, 40, 609, DateTimeKind.Local).AddTicks(7784), new DateTime(2024, 3, 25, 19, 9, 40, 609, DateTimeKind.Local).AddTicks(7783) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Articles");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "id",
                keyValue: 1,
                column: "createdAt",
                value: new DateTime(2024, 3, 24, 18, 44, 19, 109, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "id",
                keyValue: 2,
                column: "createdAt",
                value: new DateTime(2024, 3, 24, 18, 44, 19, 109, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 24, 18, 44, 19, 109, DateTimeKind.Local).AddTicks(6569), new DateTime(2024, 3, 24, 18, 44, 19, 109, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 24, 18, 44, 19, 109, DateTimeKind.Local).AddTicks(6572), new DateTime(2024, 3, 24, 18, 44, 19, 109, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 24, 18, 44, 19, 109, DateTimeKind.Local).AddTicks(6574), new DateTime(2024, 3, 24, 18, 44, 19, 109, DateTimeKind.Local).AddTicks(6573) });
        }
    }
}

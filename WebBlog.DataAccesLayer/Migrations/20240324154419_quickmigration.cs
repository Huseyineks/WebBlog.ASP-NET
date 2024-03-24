using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBlog.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class quickmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "id",
                keyValue: 1,
                column: "createdAt",
                value: new DateTime(2024, 3, 22, 15, 24, 45, 683, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "id",
                keyValue: 2,
                column: "createdAt",
                value: new DateTime(2024, 3, 22, 15, 24, 45, 683, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 22, 15, 24, 45, 683, DateTimeKind.Local).AddTicks(8014), new DateTime(2024, 3, 22, 15, 24, 45, 683, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 22, 15, 24, 45, 683, DateTimeKind.Local).AddTicks(8016), new DateTime(2024, 3, 22, 15, 24, 45, 683, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 22, 15, 24, 45, 683, DateTimeKind.Local).AddTicks(8018), new DateTime(2024, 3, 22, 15, 24, 45, 683, DateTimeKind.Local).AddTicks(8017) });
        }
    }
}

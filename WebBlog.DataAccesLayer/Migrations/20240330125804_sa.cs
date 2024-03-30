using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBlog.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class sa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "id",
                keyValue: 1,
                column: "createdAt",
                value: new DateTime(2024, 3, 30, 15, 58, 4, 122, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "id",
                keyValue: 2,
                column: "createdAt",
                value: new DateTime(2024, 3, 30, 15, 58, 4, 122, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 15, 58, 4, 123, DateTimeKind.Local).AddTicks(1903), new DateTime(2024, 3, 30, 15, 58, 4, 123, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 15, 58, 4, 123, DateTimeKind.Local).AddTicks(1906), new DateTime(2024, 3, 30, 15, 58, 4, 123, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 15, 58, 4, 123, DateTimeKind.Local).AddTicks(1908), new DateTime(2024, 3, 30, 15, 58, 4, 123, DateTimeKind.Local).AddTicks(1907) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "id",
                keyValue: 1,
                column: "createdAt",
                value: new DateTime(2024, 3, 30, 15, 56, 52, 999, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "id",
                keyValue: 2,
                column: "createdAt",
                value: new DateTime(2024, 3, 30, 15, 56, 52, 999, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 15, 56, 52, 999, DateTimeKind.Local).AddTicks(6288), new DateTime(2024, 3, 30, 15, 56, 52, 999, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 15, 56, 52, 999, DateTimeKind.Local).AddTicks(6290), new DateTime(2024, 3, 30, 15, 56, 52, 999, DateTimeKind.Local).AddTicks(6289) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 15, 56, 52, 999, DateTimeKind.Local).AddTicks(6292), new DateTime(2024, 3, 30, 15, 56, 52, 999, DateTimeKind.Local).AddTicks(6291) });
        }
    }
}

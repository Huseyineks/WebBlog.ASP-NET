using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebBlog.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class deneme1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.id);
                    table.ForeignKey(
                        name: "FK_Articles_AppUsers_userId",
                        column: x => x.userId,
                        principalTable: "AppUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    articleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comments_AppUsers_userId",
                        column: x => x.userId,
                        principalTable: "AppUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_articleId",
                        column: x => x.articleId,
                        principalTable: "Articles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "id", "createdAt", "email", "first_name", "last_name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 21, 17, 34, 56, 624, DateTimeKind.Local).AddTicks(1719), "erhan", "sa", "Turker" },
                    { 2, new DateTime(2024, 3, 21, 17, 34, 56, 624, DateTimeKind.Local).AddTicks(1728), "erhan", "as", "Turker" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_userId",
                table: "Articles",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_articleId",
                table: "Comments",
                column: "articleId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_userId",
                table: "Comments",
                column: "userId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "AppUsers");
        }
    }
}

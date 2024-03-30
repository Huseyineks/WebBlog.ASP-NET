using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebBlog.DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.id);
                    table.ForeignKey(
                        name: "FK_Articles_AppUsers_userId",
                        column: x => x.userId,
                        principalTable: "AppUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commentAuthor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: true),
                    articleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comments_AppUsers_userId",
                        column: x => x.userId,
                        principalTable: "AppUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_articleId",
                        column: x => x.articleId,
                        principalTable: "Articles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "id", "createdAt", "email", "first_name", "last_name", "password" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 30, 15, 56, 52, 999, DateTimeKind.Local).AddTicks(3057), "erhan", "sa", "Turker1231", "serdar" },
                    { 2, new DateTime(2024, 3, 30, 15, 56, 52, 999, DateTimeKind.Local).AddTicks(3068), "erhan", "as", "Turker", "serdar12312" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "id", "Author", "description", "Image", "title", "createdAt", "updatedAt", "userId" },
                values: new object[,]
                {
                    { 2, "erhan", "akjsdnkjasashkjd", "sa", "sa123", new DateTime(2024, 3, 30, 15, 56, 52, 999, DateTimeKind.Local).AddTicks(6288), new DateTime(2024, 3, 30, 15, 56, 52, 999, DateTimeKind.Local).AddTicks(6280), 1 },
                    { 3, "erhan", "akjsdnkjasashkjd", "as", "sa123", new DateTime(2024, 3, 30, 15, 56, 52, 999, DateTimeKind.Local).AddTicks(6290), new DateTime(2024, 3, 30, 15, 56, 52, 999, DateTimeKind.Local).AddTicks(6289), 1 },
                    { 4, "erhan", "akjsdnkjasashkjd", "sa", "sa123", new DateTime(2024, 3, 30, 15, 56, 52, 999, DateTimeKind.Local).AddTicks(6292), new DateTime(2024, 3, 30, 15, 56, 52, 999, DateTimeKind.Local).AddTicks(6291), 2 }
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

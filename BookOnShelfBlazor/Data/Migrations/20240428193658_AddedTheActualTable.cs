using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookOnShelfBlazor.Migrations
{
    /// <inheritdoc />
    public partial class AddedTheActualTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BooksInAwaitOfGetting",
                columns: table => new
                {
                    BooksInAwaitOfGettingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId1 = table.Column<int>(type: "int", nullable: false),
                    UserIdId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BeginDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksInAwaitOfGetting", x => x.BooksInAwaitOfGettingId);
                    table.ForeignKey(
                        name: "FK_BooksInAwaitOfGetting_AspNetUsers_UserIdId",
                        column: x => x.UserIdId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksInAwaitOfGetting_Books_BookId1",
                        column: x => x.BookId1,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BooksInAwaitOfGetting_BookId1",
                table: "BooksInAwaitOfGetting",
                column: "BookId1");

            migrationBuilder.CreateIndex(
                name: "IX_BooksInAwaitOfGetting_UserIdId",
                table: "BooksInAwaitOfGetting",
                column: "UserIdId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksInAwaitOfGetting");
        }
    }
}

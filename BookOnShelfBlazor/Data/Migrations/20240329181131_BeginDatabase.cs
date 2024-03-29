using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookOnShelfBlazor.Migrations
{
    /// <inheritdoc />
    public partial class BeginDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FkUserInfo",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    UserInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HouseNumber = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    HouseNumberAddition = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.UserInfoId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ISBN = table.Column<int>(type: "int", maxLength: 13, nullable: false),
                    AmountOfPages = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    AmountAvailable = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    FkGenreId = table.Column<int>(type: "int", nullable: false),
                    FkLanguageId = table.Column<int>(type: "int", nullable: false),
                    FrontCover = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    BackCover = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Genres_FkGenreId",
                        column: x => x.FkGenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Languages_FkLanguageId",
                        column: x => x.FkLanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BooksHistory",
                columns: table => new
                {
                    BooksHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkBookId = table.Column<int>(type: "int", nullable: false),
                    FkUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BorrowBeginDate = table.Column<DateOnly>(type: "date", nullable: false),
                    BorrowEndDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksHistory", x => x.BooksHistoryId);
                    table.ForeignKey(
                        name: "FK_BooksHistory_AspNetUsers_FkUserId",
                        column: x => x.FkUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksHistory_Books_FkBookId",
                        column: x => x.FkBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowedBooks",
                columns: table => new
                {
                    BorrowedBooksId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkBookId = table.Column<int>(type: "int", nullable: false),
                    FkUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BorrowBeginDate = table.Column<DateOnly>(type: "date", nullable: false),
                    BorrowEndDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowedBooks", x => x.BorrowedBooksId);
                    table.ForeignKey(
                        name: "FK_BorrowedBooks_AspNetUsers_FkUserId",
                        column: x => x.FkUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BorrowedBooks_Books_FkBookId",
                        column: x => x.FkBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservedBooks",
                columns: table => new
                {
                    ReservedBooksId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkBookId = table.Column<int>(type: "int", nullable: false),
                    FkUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReservedBeginDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservedBooks", x => x.ReservedBooksId);
                    table.ForeignKey(
                        name: "FK_ReservedBooks_AspNetUsers_FkUserId",
                        column: x => x.FkUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservedBooks_Books_FkBookId",
                        column: x => x.FkBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FkUserInfo",
                table: "AspNetUsers",
                column: "FkUserInfo");

            migrationBuilder.CreateIndex(
                name: "IX_Books_FkGenreId",
                table: "Books",
                column: "FkGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_FkLanguageId",
                table: "Books",
                column: "FkLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksHistory_FkBookId",
                table: "BooksHistory",
                column: "FkBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksHistory_FkUserId",
                table: "BooksHistory",
                column: "FkUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_FkBookId",
                table: "BorrowedBooks",
                column: "FkBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_FkUserId",
                table: "BorrowedBooks",
                column: "FkUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedBooks_FkBookId",
                table: "ReservedBooks",
                column: "FkBookId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedBooks_FkUserId",
                table: "ReservedBooks",
                column: "FkUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserInfo_FkUserInfo",
                table: "AspNetUsers",
                column: "FkUserInfo",
                principalTable: "UserInfo",
                principalColumn: "UserInfoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserInfo_FkUserInfo",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BooksHistory");

            migrationBuilder.DropTable(
                name: "BorrowedBooks");

            migrationBuilder.DropTable(
                name: "ReservedBooks");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FkUserInfo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FkUserInfo",
                table: "AspNetUsers");
        }
    }
}

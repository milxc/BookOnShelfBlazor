using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookOnShelfBlazor.Migrations
{
    /// <inheritdoc />
    public partial class AddedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RemovedBooks",
                columns: table => new
                {
                    RemovedBooksId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkBookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemovedBooks", x => x.RemovedBooksId);
                    table.ForeignKey(
                        name: "FK_RemovedBooks_Books_FkBookId",
                        column: x => x.FkBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    WriterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriterName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.WriterId);
                });

            migrationBuilder.CreateTable(
                name: "BooksWriters",
                columns: table => new
                {
                    BooksWritersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkBookid = table.Column<int>(type: "int", nullable: false),
                    FkWritersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksWriters", x => x.BooksWritersId);
                    table.ForeignKey(
                        name: "FK_BooksWriters_Books_FkBookid",
                        column: x => x.FkBookid,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksWriters_Writers_FkWritersId",
                        column: x => x.FkWritersId,
                        principalTable: "Writers",
                        principalColumn: "WriterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BooksWriters_FkBookid",
                table: "BooksWriters",
                column: "FkBookid");

            migrationBuilder.CreateIndex(
                name: "IX_BooksWriters_FkWritersId",
                table: "BooksWriters",
                column: "FkWritersId");

            migrationBuilder.CreateIndex(
                name: "IX_RemovedBooks_FkBookId",
                table: "RemovedBooks",
                column: "FkBookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksWriters");

            migrationBuilder.DropTable(
                name: "RemovedBooks");

            migrationBuilder.DropTable(
                name: "Writers");
        }
    }
}

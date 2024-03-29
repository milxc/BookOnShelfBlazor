using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookOnShelfBlazor.Migrations
{
    /// <inheritdoc />
    public partial class AddedUniqueKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Writers_WriterName",
                table: "Writers",
                column: "WriterName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserInfo_PhoneNumber",
                table: "UserInfo",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_LanguageName",
                table: "Languages",
                column: "LanguageName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genres_GenreName",
                table: "Genres",
                column: "GenreName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Writers_WriterName",
                table: "Writers");

            migrationBuilder.DropIndex(
                name: "IX_UserInfo_PhoneNumber",
                table: "UserInfo");

            migrationBuilder.DropIndex(
                name: "IX_Languages_LanguageName",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Genres_GenreName",
                table: "Genres");
        }
    }
}

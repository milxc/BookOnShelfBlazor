using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookOnShelfBlazor.Migrations
{
    /// <inheritdoc />
    public partial class WritersInfoAded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Writers_WriterName",
                table: "Writers");

            migrationBuilder.RenameColumn(
                name: "WriterName",
                table: "Writers",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "AboutMe",
                table: "Writers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Writers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Writers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "Writers",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutMe",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Writers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Writers",
                newName: "WriterName");

            migrationBuilder.CreateIndex(
                name: "IX_Writers_WriterName",
                table: "Writers",
                column: "WriterName",
                unique: true);
        }
    }
}

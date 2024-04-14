using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookOnShelfBlazor.Migrations
{
    /// <inheritdoc />
    public partial class EditedAboutMeToDescriptionWriters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AboutMe",
                table: "Writers",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Writers",
                newName: "AboutMe");
        }
    }
}

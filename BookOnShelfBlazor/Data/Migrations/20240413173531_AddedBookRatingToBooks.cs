using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookOnShelfBlazor.Migrations
{
    /// <inheritdoc />
    public partial class AddedBookRatingToBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookRating",
                table: "Books",
                type: "int",
                maxLength: 5,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookRating",
                table: "Books");
        }
    }
}

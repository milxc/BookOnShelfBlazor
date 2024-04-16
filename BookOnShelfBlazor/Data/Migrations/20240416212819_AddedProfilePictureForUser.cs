using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookOnShelfBlazor.Migrations
{
    /// <inheritdoc />
    public partial class AddedProfilePictureForUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "UserInfo",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "UserInfo");
        }
    }
}

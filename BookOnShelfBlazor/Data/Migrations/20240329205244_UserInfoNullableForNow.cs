using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookOnShelfBlazor.Migrations
{
    /// <inheritdoc />
    public partial class UserInfoNullableForNow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserInfo_FkUserInfo",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "FkUserInfo",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserInfo_FkUserInfo",
                table: "AspNetUsers",
                column: "FkUserInfo",
                principalTable: "UserInfo",
                principalColumn: "UserInfoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserInfo_FkUserInfo",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "FkUserInfo",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserInfo_FkUserInfo",
                table: "AspNetUsers",
                column: "FkUserInfo",
                principalTable: "UserInfo",
                principalColumn: "UserInfoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

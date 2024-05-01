using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABS3.Migrations
{
    /// <inheritdoc />
    public partial class blogv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Blogs_BlogId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BlogId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Blogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Users_UserId",
                table: "Blogs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Users_UserId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "Users",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_BlogId",
                table: "Users",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Blogs_BlogId",
                table: "Users",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id");
        }
    }
}

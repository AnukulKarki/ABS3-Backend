using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABS3.Migrations
{
    /// <inheritdoc />
    public partial class blog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "Users",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedOn = table.Column<string>(type: "TEXT", nullable: false),
                    Score = table.Column<int>(type: "INTEGER", nullable: false),
                    Image = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Blogs_BlogId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Users_BlogId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "Users");
        }
    }
}

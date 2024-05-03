using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABS3.Migrations
{
    /// <inheritdoc />
    public partial class change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DownVoteCount",
                table: "Blogs",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpVoteCount",
                table: "Blogs",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DownVoteCount",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "UpVoteCount",
                table: "Blogs");
        }
    }
}

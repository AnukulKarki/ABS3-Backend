using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABS3.Migrations
{
    /// <inheritdoc />
    public partial class commentv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DownVoteCount",
                table: "Comments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpVoteCount",
                table: "Comments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DownVoteCount",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UpVoteCount",
                table: "Comments");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABS3.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdatedAt",
                table: "Comments",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<bool>(
                name: "IsEdited",
                table: "Comments",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Blogs",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(byte[]),
                oldType: "BLOB",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEdited",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedAt",
                table: "Comments",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Blogs",
                type: "BLOB",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}

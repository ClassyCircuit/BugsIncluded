using Microsoft.EntityFrameworkCore.Migrations;

namespace BugsIncluded.Migrations
{
    public partial class enums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageType",
                table: "ImagePaths",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ImageType",
                table: "ImagePaths",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace BugsIncluded.Migrations
{
    public partial class imagepath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ImagePaths_Path",
                table: "ImagePaths",
                column: "Path",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ImagePaths_Path",
                table: "ImagePaths");
        }
    }
}

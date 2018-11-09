using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class Reviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Movie",
                table: "Review",
                newName: "MovieTitle");

            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "Review",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "Review");

            migrationBuilder.RenameColumn(
                name: "MovieTitle",
                table: "Review",
                newName: "Movie");
        }
    }
}
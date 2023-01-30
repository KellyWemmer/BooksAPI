using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksAPIServer.Migrations
{
    /// <inheritdoc />
    public partial class CoverItoFinished : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CoverI",
                table: "Finished",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverI",
                table: "Finished");
        }
    }
}

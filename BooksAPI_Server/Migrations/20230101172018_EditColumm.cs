using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksAPIServer.Migrations
{
    /// <inheritdoc />
    public partial class EditColumm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cover_I",
                table: "ToReads",
                newName: "CoverI");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CoverI",
                table: "ToReads",
                newName: "Cover_I");
        }
    }
}

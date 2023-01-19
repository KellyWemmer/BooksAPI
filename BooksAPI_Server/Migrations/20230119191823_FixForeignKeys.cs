using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksAPIServer.Migrations
{
    /// <inheritdoc />
    public partial class FixForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToReadsAuthors_Authors_AuthorId",
                table: "ToReadsAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_ToReadsAuthors_ToReads_ToReadId",
                table: "ToReadsAuthors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToReadsAuthors",
                table: "ToReadsAuthors");

            migrationBuilder.RenameTable(
                name: "ToReadsAuthors",
                newName: "ToReadAuthors");

            migrationBuilder.RenameIndex(
                name: "IX_ToReadsAuthors_ToReadId",
                table: "ToReadAuthors",
                newName: "IX_ToReadAuthors_ToReadId");

            migrationBuilder.RenameIndex(
                name: "IX_ToReadsAuthors_AuthorId",
                table: "ToReadAuthors",
                newName: "IX_ToReadAuthors_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToReadAuthors",
                table: "ToReadAuthors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ToReadAuthors_Authors_AuthorId",
                table: "ToReadAuthors",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToReadAuthors_ToReads_ToReadId",
                table: "ToReadAuthors",
                column: "ToReadId",
                principalTable: "ToReads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToReadAuthors_Authors_AuthorId",
                table: "ToReadAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_ToReadAuthors_ToReads_ToReadId",
                table: "ToReadAuthors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToReadAuthors",
                table: "ToReadAuthors");

            migrationBuilder.RenameTable(
                name: "ToReadAuthors",
                newName: "ToReadsAuthors");

            migrationBuilder.RenameIndex(
                name: "IX_ToReadAuthors_ToReadId",
                table: "ToReadsAuthors",
                newName: "IX_ToReadsAuthors_ToReadId");

            migrationBuilder.RenameIndex(
                name: "IX_ToReadAuthors_AuthorId",
                table: "ToReadsAuthors",
                newName: "IX_ToReadsAuthors_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToReadsAuthors",
                table: "ToReadsAuthors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ToReadsAuthors_Authors_AuthorId",
                table: "ToReadsAuthors",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToReadsAuthors_ToReads_ToReadId",
                table: "ToReadsAuthors",
                column: "ToReadId",
                principalTable: "ToReads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksAPIServer.Migrations
{
    /// <inheritdoc />
    public partial class FixBugInAuthorsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Favorites_FavoriteId",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Finished_FinishedId",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Authors_ToReads_ToReadId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_FavoriteId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_FinishedId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_ToReadId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "FavoriteId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "FinishedId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "ToReadId",
                table: "Authors");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FavoriteId",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FinishedId",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToReadId",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Authors_FavoriteId",
                table: "Authors",
                column: "FavoriteId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_FinishedId",
                table: "Authors",
                column: "FinishedId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_ToReadId",
                table: "Authors",
                column: "ToReadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Favorites_FavoriteId",
                table: "Authors",
                column: "FavoriteId",
                principalTable: "Favorites",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Finished_FinishedId",
                table: "Authors",
                column: "FinishedId",
                principalTable: "Finished",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_ToReads_ToReadId",
                table: "Authors",
                column: "ToReadId",
                principalTable: "ToReads",
                principalColumn: "Id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksAPIServer.Migrations
{
    /// <inheritdoc />
    public partial class CoverI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoritesAuthors_Authors_AuthorId",
                table: "FavoritesAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoritesAuthors_Favorites_FavoriteId",
                table: "FavoritesAuthors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FavoritesAuthors",
                table: "FavoritesAuthors");

            migrationBuilder.RenameTable(
                name: "FavoritesAuthors",
                newName: "FavoriteAuthors");

            migrationBuilder.RenameIndex(
                name: "IX_FavoritesAuthors_FavoriteId",
                table: "FavoriteAuthors",
                newName: "IX_FavoriteAuthors_FavoriteId");

            migrationBuilder.RenameIndex(
                name: "IX_FavoritesAuthors_AuthorId",
                table: "FavoriteAuthors",
                newName: "IX_FavoriteAuthors_AuthorId");

            migrationBuilder.AddColumn<int>(
                name: "CoverI",
                table: "Favorites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavoriteAuthors",
                table: "FavoriteAuthors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteAuthors_Authors_AuthorId",
                table: "FavoriteAuthors",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteAuthors_Favorites_FavoriteId",
                table: "FavoriteAuthors",
                column: "FavoriteId",
                principalTable: "Favorites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteAuthors_Authors_AuthorId",
                table: "FavoriteAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteAuthors_Favorites_FavoriteId",
                table: "FavoriteAuthors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FavoriteAuthors",
                table: "FavoriteAuthors");

            migrationBuilder.DropColumn(
                name: "CoverI",
                table: "Favorites");

            migrationBuilder.RenameTable(
                name: "FavoriteAuthors",
                newName: "FavoritesAuthors");

            migrationBuilder.RenameIndex(
                name: "IX_FavoriteAuthors_FavoriteId",
                table: "FavoritesAuthors",
                newName: "IX_FavoritesAuthors_FavoriteId");

            migrationBuilder.RenameIndex(
                name: "IX_FavoriteAuthors_AuthorId",
                table: "FavoritesAuthors",
                newName: "IX_FavoritesAuthors_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavoritesAuthors",
                table: "FavoritesAuthors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoritesAuthors_Authors_AuthorId",
                table: "FavoritesAuthors",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoritesAuthors_Favorites_FavoriteId",
                table: "FavoritesAuthors",
                column: "FavoriteId",
                principalTable: "Favorites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksAPIServer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDigitIsbn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirteenDigitIsbn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Finished",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDigitIsbn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirteenDigitIsbn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finished", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToReads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDigitIsbn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirteenDigitIsbn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToReads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FavoriteId = table.Column<int>(type: "int", nullable: true),
                    FinishedId = table.Column<int>(type: "int", nullable: true),
                    ToReadId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authors_Favorites_FavoriteId",
                        column: x => x.FavoriteId,
                        principalTable: "Favorites",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Authors_Finished_FinishedId",
                        column: x => x.FinishedId,
                        principalTable: "Finished",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Authors_ToReads_ToReadId",
                        column: x => x.ToReadId,
                        principalTable: "ToReads",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FavoritesAuthors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavoriteId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoritesAuthors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoritesAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoritesAuthors_Favorites_FavoriteId",
                        column: x => x.FavoriteId,
                        principalTable: "Favorites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinishedAuthors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinishedId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinishedAuthors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinishedAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FinishedAuthors_Finished_FinishedId",
                        column: x => x.FinishedId,
                        principalTable: "Finished",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToReadsAuthors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToReadId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToReadsAuthors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToReadsAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ToReadsAuthors_ToReads_ToReadId",
                        column: x => x.ToReadId,
                        principalTable: "ToReads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_FavoritesAuthors_AuthorId",
                table: "FavoritesAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoritesAuthors_FavoriteId",
                table: "FavoritesAuthors",
                column: "FavoriteId");

            migrationBuilder.CreateIndex(
                name: "IX_FinishedAuthors_AuthorId",
                table: "FinishedAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_FinishedAuthors_FinishedId",
                table: "FinishedAuthors",
                column: "FinishedId");

            migrationBuilder.CreateIndex(
                name: "IX_ToReadsAuthors_AuthorId",
                table: "ToReadsAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_ToReadsAuthors_ToReadId",
                table: "ToReadsAuthors",
                column: "ToReadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoritesAuthors");

            migrationBuilder.DropTable(
                name: "FinishedAuthors");

            migrationBuilder.DropTable(
                name: "ToReadsAuthors");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "Finished");

            migrationBuilder.DropTable(
                name: "ToReads");
        }
    }
}

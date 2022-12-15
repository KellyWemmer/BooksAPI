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
                name: "Favorite",
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
                    table.PrimaryKey("PK_Favorite", x => x.Id);
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
                name: "ToRead",
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
                    table.PrimaryKey("PK_ToRead", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Author",
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
                    table.PrimaryKey("PK_Author", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Author_Favorite_FavoriteId",
                        column: x => x.FavoriteId,
                        principalTable: "Favorite",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Author_Finished_FinishedId",
                        column: x => x.FinishedId,
                        principalTable: "Finished",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Author_ToRead_ToReadId",
                        column: x => x.ToReadId,
                        principalTable: "ToRead",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FavoriteAuthor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavoriteId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteAuthor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteAuthor_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteAuthor_Favorite_FavoriteId",
                        column: x => x.FavoriteId,
                        principalTable: "Favorite",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinishedAuthor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinishedId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinishedAuthor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinishedAuthor_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FinishedAuthor_Finished_FinishedId",
                        column: x => x.FinishedId,
                        principalTable: "Finished",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToReadAuthor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToReadId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToReadAuthor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToReadAuthor_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ToReadAuthor_ToRead_ToReadId",
                        column: x => x.ToReadId,
                        principalTable: "ToRead",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Author_FavoriteId",
                table: "Author",
                column: "FavoriteId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_FinishedId",
                table: "Author",
                column: "FinishedId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_ToReadId",
                table: "Author",
                column: "ToReadId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteAuthor_AuthorId",
                table: "FavoriteAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteAuthor_FavoriteId",
                table: "FavoriteAuthor",
                column: "FavoriteId");

            migrationBuilder.CreateIndex(
                name: "IX_FinishedAuthor_AuthorId",
                table: "FinishedAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_FinishedAuthor_FinishedId",
                table: "FinishedAuthor",
                column: "FinishedId");

            migrationBuilder.CreateIndex(
                name: "IX_ToReadAuthor_AuthorId",
                table: "ToReadAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_ToReadAuthor_ToReadId",
                table: "ToReadAuthor",
                column: "ToReadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteAuthor");

            migrationBuilder.DropTable(
                name: "FinishedAuthor");

            migrationBuilder.DropTable(
                name: "ToReadAuthor");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Favorite");

            migrationBuilder.DropTable(
                name: "Finished");

            migrationBuilder.DropTable(
                name: "ToRead");
        }
    }
}

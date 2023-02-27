using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6AssignmentDarbyMecham.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "newMovies",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryID = table.Column<int>(nullable: false),
                    MovieTitle = table.Column<string>(nullable: false),
                    MovieYear = table.Column<string>(nullable: false),
                    MovieDirector = table.Column<string>(nullable: false),
                    MovieRating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newMovies", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_newMovies_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Family" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 5, "Horror/Suspense" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 6, "Miscellaneous" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 7, "Mystery" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 8, "Romance" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 9, "Science Fiction" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 10, "Television" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 11, "VHS" });

            migrationBuilder.InsertData(
                table: "newMovies",
                columns: new[] { "MovieID", "CategoryID", "Edited", "LentTo", "MovieDirector", "MovieRating", "MovieTitle", "MovieYear", "Notes" },
                values: new object[] { 2, 2, false, "Chloe", "Michael McCullers", "PG-13", "Baby Mama", "2008", "Funniest movie" });

            migrationBuilder.InsertData(
                table: "newMovies",
                columns: new[] { "MovieID", "CategoryID", "Edited", "LentTo", "MovieDirector", "MovieRating", "MovieTitle", "MovieYear", "Notes" },
                values: new object[] { 3, 4, false, "Adaly", "Jorge R. Gutierrez", "PG", "Book of Life", "2014", "None" });

            migrationBuilder.InsertData(
                table: "newMovies",
                columns: new[] { "MovieID", "CategoryID", "Edited", "LentTo", "MovieDirector", "MovieRating", "MovieTitle", "MovieYear", "Notes" },
                values: new object[] { 1, 8, false, "Mom", "Jon M. Chu", "PG-13", "Crazy Rich Asians", "2018", "None" });

            migrationBuilder.CreateIndex(
                name: "IX_newMovies_CategoryID",
                table: "newMovies",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "newMovies");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

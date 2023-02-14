using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6AssignmentDarbyMecham.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "newMovies",
                columns: table => new
                {
                    MovieTitle = table.Column<string>(nullable: false),
                    MovieCategory = table.Column<string>(nullable: false),
                    MovieYear = table.Column<string>(nullable: false),
                    MovieDirector = table.Column<string>(nullable: false),
                    MovieRating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newMovies", x => x.MovieTitle);
                });

            migrationBuilder.InsertData(
                table: "newMovies",
                columns: new[] { "MovieTitle", "Edited", "LentTo", "MovieCategory", "MovieDirector", "MovieRating", "MovieYear", "Notes" },
                values: new object[] { "Crazy Rich Asians", false, "Mom", "Romantic Comedy", "Jon M. Chu", "PG-13", "2018", "None" });

            migrationBuilder.InsertData(
                table: "newMovies",
                columns: new[] { "MovieTitle", "Edited", "LentTo", "MovieCategory", "MovieDirector", "MovieRating", "MovieYear", "Notes" },
                values: new object[] { "Baby Mama", false, "Chloe", "Comedy", "Michael McCullers", "PG-13", "2008", "Funiest movie" });

            migrationBuilder.InsertData(
                table: "newMovies",
                columns: new[] { "MovieTitle", "Edited", "LentTo", "MovieCategory", "MovieDirector", "MovieRating", "MovieYear", "Notes" },
                values: new object[] { "Book of Life", false, "Adaly", "Childrens", "Jorge R. Gutierrez", "PG", "2014", "None" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "newMovies");
        }
    }
}

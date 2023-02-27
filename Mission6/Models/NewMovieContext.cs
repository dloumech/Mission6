using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6AssignmentDarbyMecham.Models
{
    public class NewMovieContext : DbContext
    {
        //constructor
        public NewMovieContext (DbContextOptions<NewMovieContext> options) : base (options)
        {
            //leave blank for now
        }

        public DbSet<NewMovie> newMovies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID=1, CategoryName="Action/Adventure" },
                new Category { CategoryID = 2, CategoryName ="Comedy"},
                new Category { CategoryID = 3, CategoryName = "Drama"},
                new Category { CategoryID = 4, CategoryName = "Family" },
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense"},
                new Category { CategoryID = 6, CategoryName = "Miscellaneous"},
                new Category { CategoryID = 7, CategoryName = "Mystery"},
                new Category { CategoryID = 8, CategoryName = "Romance"},
                new Category { CategoryID = 9, CategoryName = "Science Fiction"},
                new Category { CategoryID = 10, CategoryName = "Television"},
                new Category { CategoryID = 11, CategoryName = "VHS"} //some categories from Joels current spreadsheet, some from Google
            );

            mb.Entity<NewMovie>().HasData(

                new NewMovie
                {
                    MovieID = 1,
                    CategoryID=8,
                    MovieTitle="Crazy Rich Asians",
                    MovieYear="2018",
                    MovieDirector="Jon M. Chu",
                    MovieRating="PG-13",
                    Edited=false,
                    LentTo="Mom",
                    Notes="None"
                },
                new NewMovie
                {
                    MovieID = 2,
                    CategoryID=2,
                    MovieTitle = "Baby Mama",
                    MovieYear = "2008",
                    MovieDirector = "Michael McCullers",
                    MovieRating = "PG-13",
                    Edited = false,
                    LentTo = "Chloe",
                    Notes = "Funniest movie"
                },
                new NewMovie
                {
                    MovieID = 3,
                    CategoryID = 4,
                    MovieTitle = "Book of Life",
                    MovieYear = "2014",
                    MovieDirector = "Jorge R. Gutierrez",
                    MovieRating = "PG",
                    Edited = false,
                    LentTo = "Adaly",
                    Notes = "None"
                }
                );
        }
    }
}

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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<NewMovie>().HasData(

                new NewMovie
                {
                    MovieCategory="Romantic Comedy",
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
                    MovieCategory = "Comedy",
                    MovieTitle = "Baby Mama",
                    MovieYear = "2008",
                    MovieDirector = "Michael McCullers",
                    MovieRating = "PG-13",
                    Edited = false,
                    LentTo = "Chloe",
                    Notes = "Funiest movie"
                },
                new NewMovie
                {
                    MovieCategory = "Childrens",
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

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
    }
}

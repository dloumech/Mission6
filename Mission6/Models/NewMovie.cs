using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Mission6AssignmentDarbyMecham.Models;

namespace Mission6AssignmentDarbyMecham.Models
{
    public class NewMovie
    {
        //category, title, year, director, edited, lent to, notes
        [Required]
        //build foreign key relationship
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        [Key]
        [Required] 
        public int MovieID { get; set; }
        [Required]
        public string MovieTitle { get; set; }
        [Required]
        public string MovieYear { get; set; }
        [Required]
        public string MovieDirector { get; set; }
        [Required]
        public string MovieRating { get; set; }
        
        //optional fields 
        public bool Edited { get; set; }
        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }
    }
}

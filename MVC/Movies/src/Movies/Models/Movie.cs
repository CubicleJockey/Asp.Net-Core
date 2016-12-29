using System;
using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required, StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        
        [Required, DataType(DataType.Date), Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        
        [Required, StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Genre { get; set; }

        [Required, Range(1, 100), DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required, StringLength(5)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Rating { get; set; }
    }
}

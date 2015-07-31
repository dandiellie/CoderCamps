using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter a movie title!")]
        public string Title { get; set; }

        [StringLength(25, ErrorMessage = "The director's name may be at most 25 characters.")]
        public string Director { get; set; }

        public string PictureURL { get; set; }
    }
}
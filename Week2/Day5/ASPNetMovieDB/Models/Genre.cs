using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNetMovieDB.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Genre")]
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstPractice.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
                
        public string Description { get; set; }

        [Required]
        [DisplayName("Price Range")]
        public string PriceRange { get; set; }
    }
}
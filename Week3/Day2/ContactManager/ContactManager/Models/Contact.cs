using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactManager.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression("(\\d{3}) \\d{3} - \\d{4}", ErrorMessage = "Invalid Phone Number!")]
        public string PhoneNumber { get; set; }
    }
}
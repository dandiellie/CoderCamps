using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetModelState.Models
{
    public class RegistrationViewModel
    {
        public int Id { get; set; }

        [Required]
        [Remote("ValidateUsername", "Registration", ErrorMessage="Username already in use. Please try another username.", HttpMethod="POST")]
        public string Username { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.CreditCard)]
        [DisplayName("Credit Card")]
        public long CreditCard { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }

        [DisplayName("SSN")]
        [RegularExpression("^\\d{3}-\\d{2}-\\d{4}$", ErrorMessage="Please enter your SSN in the form ###-##-####.")]
        public string Social { get; set; }

        [MaxLength(50)]
        public string Comments { get; set; }
    }
}
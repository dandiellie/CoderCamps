using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNetModelState.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Product name is required!")]
        [MaxLength(20, ErrorMessage="Product name is too long!")]
        [Remote("ValidateProduct", "Products", ErrorMessage="Product name must be unique!", HttpMethod="POST")]
        public string Name { get; set; }
        [Range(0,100,ErrorMessage="Price must be between 0 and 100!")]
        public decimal Price { get; set; }
    }
}
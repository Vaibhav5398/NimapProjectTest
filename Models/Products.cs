using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NimapProjectTest.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is Required")]
        public string ProductName { get; set; }

        public int CategoryId { get; set; }

        //[ForeignKey(nameof(Products))]
        public string CategoryName { get; set; }



    }
}
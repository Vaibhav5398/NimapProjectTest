using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NimapProjectTest.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category Name is Required")]
        public string CategoryName { get; set; }
    }

    
}
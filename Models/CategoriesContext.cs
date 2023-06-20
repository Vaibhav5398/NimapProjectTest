using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NimapProjectTest.Models
{
    public class CategoriesContext:DbContext
    {


        public DbSet<Categories> Category { get; set; }

        public DbSet<Products> Product { get; set; }




    }
}
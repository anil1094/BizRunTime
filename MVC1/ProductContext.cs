using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FileResult.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProductsConnection")
        {

        }
        public DbSet<Product> ProductTable { get; set; }
    }
}
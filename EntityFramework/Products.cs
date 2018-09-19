using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("tbleProducts")]
    public class Products
    {
        [Key]
        public int productId { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }

        public Category Category { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace FileResult.Models
{
    [Table("tbProduct")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string name { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}
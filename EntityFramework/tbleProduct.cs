//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbleProduct
    {
        public int productId { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }
        public Nullable<int> Category_CategoryId { get; set; }
    
        public virtual tblCategory tblCategory { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DuckShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movement
    {
        public int Id { get; set; }
        public Nullable<int> WerehauseFrom { get; set; }
        public string WerehauseTo { get; set; }
        public System.DateTime DateMovement { get; set; }
        public int Count { get; set; }
        public int Product { get; set; }
        public double Price { get; set; }
    
        public virtual Product Product1 { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}

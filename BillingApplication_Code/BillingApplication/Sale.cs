//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BillingApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public Sale()
        {
            this.Sale_Details = new HashSet<Sale_Details>();
        }
    
        public int SaleID { get; set; }
        public Nullable<decimal> SubAmount { get; set; }
        public Nullable<decimal> VAT { get; set; }
        public Nullable<decimal> SaleAmount { get; set; }
        public string SaleType { get; set; }
        public Nullable<System.DateTime> SaleDate { get; set; }
        public string Cust_Name { get; set; }
    
        public virtual ICollection<Sale_Details> Sale_Details { get; set; }
    }
}
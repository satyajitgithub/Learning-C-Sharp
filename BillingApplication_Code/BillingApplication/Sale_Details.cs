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
    
    public partial class Sale_Details
    {
        public int SaleDetailId { get; set; }
        public Nullable<int> SaleID { get; set; }
        public string Item_Name { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<decimal> Before_VAT { get; set; }
        public Nullable<decimal> VAT { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> SaleAmount { get; set; }
        public Nullable<System.DateTime> SaleDate { get; set; }
        public string SaleType { get; set; }
        public string Cust_Name { get; set; }
    
        public virtual Sale Sale { get; set; }
    }
}
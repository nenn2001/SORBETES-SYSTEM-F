//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dbsys.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class SALESsold
    {
        public SALESsold()
        {
            this.SALESsold1 = new HashSet<SALESsold>();
        }
    
        public int SaleID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<int> QuantityChocolate { get; set; }
        public Nullable<int> QuantityStrawberry { get; set; }
        public Nullable<int> QuantityBerry { get; set; }
        public Nullable<int> QuantityMelon { get; set; }
        public Nullable<int> QuantityVanilla { get; set; }
        public Nullable<int> QuantityCherry { get; set; }
        public Nullable<int> QuantityCreamy { get; set; }
        public Nullable<int> QuantityMacha { get; set; }
        public string ModeOfPayment { get; set; }
        public Nullable<decimal> EAmount { get; set; }
        public Nullable<decimal> TotalCost { get; set; }
        public Nullable<decimal> ChangeAmount { get; set; }
    
        public virtual ICollection<SALESsold> SALESsold1 { get; set; }
        public virtual SALESsold SALESsold2 { get; set; }
    }
}

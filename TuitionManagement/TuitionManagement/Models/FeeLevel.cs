//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TuitionManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeeLevel
    {
        public FeeLevel()
        {
            this.Invoice = new HashSet<Invoice>();
            this.Receipt = new HashSet<Receipt>();
        }
    
        public int FeeLevelId { get; set; }
        public int PaidTime { get; set; }
        public double TotalMoney { get; set; }
        public int Period { get; set; }
        public int ObjectID { get; set; }
    
        public virtual Object Object { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<Receipt> Receipt { get; set; }
    }
}

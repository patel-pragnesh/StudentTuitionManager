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
    
    public partial class Function
    {
        public Function()
        {
            this.RoleFunction = new HashSet<RoleFunction>();
        }
    
        public int FunctionId { get; set; }
        public string FunctionName { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<RoleFunction> RoleFunction { get; set; }
    }
}
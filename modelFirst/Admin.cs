//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace modelFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admin : Person
    {
        public Admin()
        {
            this.Businesses = new HashSet<Business>();
        }
    
    
        public virtual ICollection<Business> Businesses { get; set; }
    }
}

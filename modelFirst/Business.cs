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
    
    public partial class Business
    {
        public Business()
        {
            this.Coupons = new HashSet<Coupon>();
        }
    
        public int BusinessID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public Category Category { get; set; }
        public int AdminId { get; set; }
        public int BusinessOwnerId { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual BusinessOwner BusinessOwner { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }
    }
}

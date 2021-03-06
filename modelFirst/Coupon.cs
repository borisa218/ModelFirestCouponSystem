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
    
    public partial class Coupon
    {
        public Coupon()
        {
            this.BuyingCustomers = new HashSet<Customer>();
        }
    
        public int CouponID { get; set; }
        public string Name { get; set; }
        public int OriginalPrice { get; set; }
        public int DiscountPrice { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    
        public virtual Business FromBusiness { get; set; }
        public virtual ICollection<Customer> BuyingCustomers { get; set; }
        public virtual Location Location { get; set; }
    }
}

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
    
    public partial class OrderedCoupon
    {
        public int OrderedCouponID { get; set; }
        public bool Used { get; set; }
        public int Rank { get; set; }
        public int CouponCouponID { get; set; }
    
        public virtual Coupon Coupon { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
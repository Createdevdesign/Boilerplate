//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BoilerSupplier.DataTransferObject
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerServiceRequestStatu
    {
        public decimal Id { get; set; }
        public string ServiceRequestNumber { get; set; }
        public string ActionRemark { get; set; }
        public Nullable<decimal> PaymentAction { get; set; }
        public Nullable<decimal> Status { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}

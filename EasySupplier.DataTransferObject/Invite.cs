﻿//------------------------------------------------------------------------------
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

    public partial class Invite
    {
        
            public int EmpRoleType { get; set; }
        public string LoginEmailID { get; set; }
        public string YourName { get; set; }
        public string CompanyName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string CompanyAddress { get; set; }
        public string ITEquipment { get; set; }
        public string Software { get; set; }
        public string Peripherals { get; set; }
        public string OfficeEquipment { get; set; }
        public string OfficeSupplies { get; set; }
        public string ManpowerServices { get; set; }
        public string OtherServices { get; set; }
        public string ProductsServicesforFacilityManagement { get; set; }
        public string ReasonForContact { get; set; }
        public string PurchasingOrganisation { get; set; }
        public string PurchasingOrgID { get; set; }
        public string PurchasingOrgCode { get; set; }

        public DateTime CreatedDate { get; set; }

        //public string LoginEmailID { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string PurchasingOrgName { get; set; }

        //public string PurchasingOrgID { get; set; }
        //public string Invitedby { get; set; }
        //public string CompanyName { get; set; }
        //public string ContactNo { get; set; }
        //public string PurOrgCode { get; set; }



        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public string MODE { get; set; }
    }
}


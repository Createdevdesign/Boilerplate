﻿
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

    public partial class RegisterList
    {
        public string LoginEmailID { get; set; }
        public string VendorCode { get; set; }
        public string EmpName { get; set; }
        public string PurchasingOrgDesc { get; set; }

        public string SAPVendorCode { get; set; }
        public string EstablishmentName { get; set; }
        public string CountryName { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNo { get; set; }
        public DateTime SubmitedDate
        { get; set; }
        public string Status
        { get; set; }
        public string WFStatusID
        { get; set; }
        public string ParentID { get; set; }
        public string SubmitFlag
        { get; set; }
        public string CompEmailId
        { get; set; }
        public string Visibility
        { get; set; }
        public string ShortName

        { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate
        { get; set; }



        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public string MODE { get; set; }
    }
}

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
    public partial class VendorDocument
    {
        public int Doc_ID { get; set; }
        public string Vendor_Code { get; set; }
        public string Document_Type { get; set; }
        public string Document_Name { get; set; }
        public DateTime Expiry_Date { get; set; }
        public string Document_Path { get; set; }


        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public string MODE { get; set; }
    }
}

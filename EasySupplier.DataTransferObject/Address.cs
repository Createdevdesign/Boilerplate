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
    
    public partial class Address
    {
        public decimal Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public Nullable<int> TalukaId { get; set; }
        public int DistrictId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string PostalCode { get; set; }
        //public System.Data.Entity.Spatial.DbGeography SpatialLocation { get; set; }
        //public  string SpatialLocation { get; set; }
        public string UserCode { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public bool IsActive { get; set; }
        public string Entitytype { get; set; }

        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public string MODE { get; set; }
    }
}

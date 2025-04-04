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

    public partial class FileSchema
    {

       
        public Nullable<decimal> id { get; set; }

        public string TransactionHeaderid { get; set; }
        public string FileID { get; set; }
        public string DestinationAgency { get; set; }
        public string Merchantid { get; set; }
        public string Submerchantid { get; set; }
        public string Filetypeid { get; set; }
        public string Filename { get; set; }
        public int Filestatus { get; set; }
        public Nullable<System.DateTime> FileCreateddate { get; set; }
        public Nullable<System.DateTime> LastProcessingDate { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string BackupPath { get; set; }
        public string NoofRecords { get; set; }
        public string SuccessfullProcessRecord { get; set; }
        public string UnsuccessfullRecord { get; set; }
        public string Remarks { get; set; }

        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public string MODE { get; set; }

    }
}

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

    public partial class FileMaster
    {

        public decimal Id { get; set; }
        public string InputFileName { get; set; }
        public string Fileextension { get; set; }
        public decimal ProjectId { get; set; }
        public bool isActive { get; set; }
        public string FileDirection { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string Description { get; set; }
        public decimal GenerationMethod { get; set; }

        public bool IsOneWay { get; set; }

        public string ResponseFileName { get; set; }
        public bool ErrorSendingByEmail { get; set; }
      
        public bool ErrorLogInSQL { get; set; }
        public bool IsReprocessRequire { get; set; }

        public string ErrorLogTables  { get; set; }
        public string ErrorLogPage { get; set; }
    

        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public string MODE { get; set; }
    }
}


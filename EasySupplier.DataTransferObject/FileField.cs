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

    public partial class FileField
    {

       

        public decimal Id { get; set; }
        public decimal FileId { get; set; }
        public string FieldName { get; set; }
        public string FieldDatatype { get; set; }
        public string FieldType { get; set; }
        public string Pattern { get; set; }
        public bool IsMandatory { get; set; }
        public decimal FieldMaxLenth { get; set; }

        public string Fieldexpression { get; set; }
        public string Comments { get; set; }
        public bool IsActive { get; set; }

        public decimal Ordering { get; set; }
        public string Label { get; set; }
        public decimal FileSectionType { get; set; }

        
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public string MODE { get; set; }
    }
}








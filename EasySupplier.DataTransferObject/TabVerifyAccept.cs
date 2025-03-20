
namespace BoilerSupplier.DataTransferObject
{

    using System;
    using System.Collections.Generic;
    public partial class TabVerifyAccept
    {

        public string VendorCode { get; set; }

        public int Info { get; set; }
        public int Bank { get; set; }
        public int Financial { get; set; }
        public int Certificates { get; set; }
        public int Reference { get; set; }
        public int Additional { get; set; }
        public int NDA { get; set; }
        public int TCOC { get; set; }
        public int Documents { get; set; }
        public int TTLUse { get; set; }

        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public string MODE { get; set; }


    }
}
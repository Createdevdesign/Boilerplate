
namespace BoilerSupplier.DataTransferObject
{

    using System;
    using System.Collections.Generic;
    public partial class Tabfields
    {

        //-----------------------Tabfields--------

        public string LoginEmailID { get; set; }

        public string Token { get; set; }

        public int RelationID { get; set; }
        public int OrganisationID { get; set; }
        public int TabID { get; set; }
        public int FieldID { get; set; }

        public string Label { get; set; }
        public bool Required { get; set; }
        public string Placeholder { get; set; }
        public string Tooltip { get; set; }
        public bool Status { get; set; }
        public bool Enabled { get; set; }
        public decimal Ordering { get; set; }
        public string ContainerCssClass { get; set; }
        public bool Show { get; set; }
        public bool Public { get; set; }
        public bool Short { get; set; }

        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public string MODE { get; set; }


    }
}
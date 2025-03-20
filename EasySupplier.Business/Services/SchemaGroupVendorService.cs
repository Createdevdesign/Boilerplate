using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   
    internal class SchemaGroupVendorService : ISchemaGroupVendorService
    {
        private IDataManger SchemaGroupVendorDataManger;

        public SchemaGroupVendorService(DataManger dataManger)
        {
            this.SchemaGroupVendorDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllSchemaGroupVendorData(SAPMaster input)
        {
            var SchemaGroupVendorData = SchemaGroupVendorDataManger.GetAllSchemaGroupVendorData(input);
            return SchemaGroupVendorData;
        }
    }
}

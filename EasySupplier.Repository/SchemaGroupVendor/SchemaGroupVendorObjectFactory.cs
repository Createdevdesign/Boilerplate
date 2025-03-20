using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   
    internal class SchemaGroupVendorObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster SchemaGroupVendor = new SAPMaster();

            SchemaGroupVendor.MANDT = null != reader[Constants.OUT_MANDT] ? Convert.ToInt32(reader[Constants.OUT_MANDT].ToString().Trim()) : 0;
            SchemaGroupVendor.KALSK = null != reader[Constants.OUT_KALSK] ? reader[Constants.OUT_KALSK].ToString().Trim() : string.Empty;
            SchemaGroupVendor.KALSB = null != reader[Constants.OUT_KALSB] ? reader[Constants.OUT_KALSB].ToString().Trim() : string.Empty;

            return SchemaGroupVendor;
        }
    }
}

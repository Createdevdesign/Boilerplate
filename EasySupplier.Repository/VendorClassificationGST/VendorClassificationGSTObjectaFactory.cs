using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   
    internal class VendorClassificationGSTObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster VendorClassificationGST = new SAPMaster();

            VendorClassificationGST.GST_ID = null != reader[Constants.OUT_GST_ID] ? Convert.ToInt32(reader[Constants.OUT_GST_ID].ToString().Trim()) : 0;
            //VendorClassificationGST.GST_ID = null != reader[Constants.OUT_GST_ID] ? reader[Constants.OUT_GST_ID].ToString().Trim() : string.Empty;
            VendorClassificationGST.VEN_CLASS = null != reader[Constants.OUT_VEN_CLASS] ? reader[Constants.OUT_VEN_CLASS].ToString().Trim() : string.Empty;
            

            return VendorClassificationGST;
        }
    }
}

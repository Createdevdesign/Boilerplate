using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   
    internal class WithholdingTaxCodeObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster WithholdingTaxCode = new SAPMaster();

            WithholdingTaxCode.MANDT = null != reader[Constants.OUT_MANDT] ? Convert.ToInt32(reader[Constants.OUT_MANDT].ToString().Trim()) : 0;
            WithholdingTaxCode.WT_WITHCD = null != reader[Constants.OUT_WT_WITHCD] ? reader[Constants.OUT_WT_WITHCD].ToString().Trim() : string.Empty;
            WithholdingTaxCode.TEXT40 = null != reader[Constants.OUT_TEXT40] ? reader[Constants.OUT_TEXT40].ToString().Trim() : string.Empty;

            return WithholdingTaxCode;
        }
    }
}

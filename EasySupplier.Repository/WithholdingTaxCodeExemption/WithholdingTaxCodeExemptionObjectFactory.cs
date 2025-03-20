using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    internal class WithholdingTaxCodeExemptionObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster WithholdingTaxCodeExemption = new SAPMaster();

            WithholdingTaxCodeExemption.MANDT = null != reader[Constants.OUT_MANDT] ? Convert.ToInt32(reader[Constants.OUT_MANDT].ToString().Trim()) : 0;
            WithholdingTaxCodeExemption.WT_WITHCD = null != reader[Constants.OUT_WT_WITHCD] ? reader[Constants.OUT_WT_WITHCD].ToString().Trim() : string.Empty;
            WithholdingTaxCodeExemption.TEXT40 = null != reader[Constants.OUT_TEXT40] ? reader[Constants.OUT_TEXT40].ToString().Trim() : string.Empty;

            return WithholdingTaxCodeExemption;
        }
    }
}

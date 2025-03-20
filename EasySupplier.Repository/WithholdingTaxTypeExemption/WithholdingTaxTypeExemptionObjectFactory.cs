using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    internal class WithholdingTaxTypeExemptionObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster WithholdingTaxTypeExemption = new SAPMaster();

            WithholdingTaxTypeExemption.MANDT = null != reader[Constants.OUT_MANDT] ? Convert.ToInt32(reader[Constants.OUT_MANDT].ToString().Trim()) : 0;
            WithholdingTaxTypeExemption.WITHT = null != reader[Constants.OUT_WITHT] ? reader[Constants.OUT_WITHT].ToString().Trim() : string.Empty;
            WithholdingTaxTypeExemption.TEXT40 = null != reader[Constants.OUT_TEXT40] ? reader[Constants.OUT_TEXT40].ToString().Trim() : string.Empty;

            return WithholdingTaxTypeExemption;
        }
    }
}

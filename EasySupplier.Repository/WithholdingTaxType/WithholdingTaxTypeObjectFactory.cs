using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;
namespace BoilerSupplier.Repository
{
   
    internal class WithholdingTaxTypeObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster WithholdingTaxType = new SAPMaster();

            WithholdingTaxType.MANDT = null != reader[Constants.OUT_MANDT] ? Convert.ToInt32(reader[Constants.OUT_MANDT].ToString().Trim()) : 0;
            WithholdingTaxType.WITHT = null != reader[Constants.OUT_WITHT] ? reader[Constants.OUT_WITHT].ToString().Trim() : string.Empty;
            WithholdingTaxType.TEXT40 = null != reader[Constants.OUT_TEXT40] ? reader[Constants.OUT_TEXT40].ToString().Trim() : string.Empty;

            return WithholdingTaxType;
        }
    }
}

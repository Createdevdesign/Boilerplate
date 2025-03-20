using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
  
    internal class PaymentTermLevelObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster PaymentTermLevel = new SAPMaster();

            PaymentTermLevel.MANDT = null != reader[Constants.OUT_MANDT] ? Convert.ToInt32(reader[Constants.OUT_MANDT].ToString().Trim()) : 0;
            PaymentTermLevel.ZTERM = null != reader[Constants.OUT_ZTERM] ? reader[Constants.OUT_ZTERM].ToString().Trim() : string.Empty;
            PaymentTermLevel.TEXT1 = null != reader[Constants.OUT_TEXT1] ? reader[Constants.OUT_TEXT1].ToString().Trim() : string.Empty;

            return PaymentTermLevel;
        }
    }
}

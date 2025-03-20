using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
        internal class PaymentMethodsObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster PaymentMethods = new SAPMaster();

            PaymentMethods.MANDT = null != reader[Constants.OUT_MANDT] ? Convert.ToInt32(reader[Constants.OUT_MANDT].ToString().Trim()) : 0;
            PaymentMethods.ZLSCH = null != reader[Constants.OUT_ZLSCH] ? reader[Constants.OUT_ZLSCH].ToString().Trim() : string.Empty;
            PaymentMethods.TEXT2 = null != reader[Constants.OUT_TEXT2] ? reader[Constants.OUT_TEXT2].ToString().Trim() : string.Empty;

            return PaymentMethods;
        }
    }
}

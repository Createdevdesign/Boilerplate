using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   
    internal class PaymentTermObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster PaymentTerm = new SAPMaster();

            PaymentTerm.MANDT = null != reader[Constants.OUT_MANDT] ? Convert.ToInt32(reader[Constants.OUT_MANDT].ToString().Trim()) : 0;
            PaymentTerm.ZTERM = null != reader[Constants.OUT_ZTERM] ? reader[Constants.OUT_ZTERM].ToString().Trim() : string.Empty;
            PaymentTerm.TEXT1 = null != reader[Constants.OUT_TEXT1] ? reader[Constants.OUT_TEXT1].ToString().Trim() : string.Empty;

            return PaymentTerm;
        }
    }
}

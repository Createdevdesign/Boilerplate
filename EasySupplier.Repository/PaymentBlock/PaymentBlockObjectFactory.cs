using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   
    internal class PaymentBlockObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster PaymentBlock = new SAPMaster();

            PaymentBlock.MANDT = null != reader[Constants.OUT_MANDT] ? Convert.ToInt32(reader[Constants.OUT_MANDT].ToString().Trim()) : 0;
            PaymentBlock.ZAHLS = null != reader[Constants.OUT_ZAHLS] ? reader[Constants.OUT_ZAHLS].ToString().Trim() : string.Empty;
            PaymentBlock.TEXTL = null != reader[Constants.OUT_TEXTL] ? reader[Constants.OUT_TEXTL].ToString().Trim() : string.Empty;

            return PaymentBlock;
        }
    }
}

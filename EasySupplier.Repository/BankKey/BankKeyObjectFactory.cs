using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
  

    internal class BankKeyObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster BankKey = new SAPMaster();

            BankKey.MANDT = null != reader[Constants.OUT_MANDT] ? Convert.ToInt32(reader[Constants.OUT_MANDT].ToString().Trim()) : 0;
            BankKey.BANKL = null != reader[Constants.OUT_BANKL] ? reader[Constants.OUT_BANKL].ToString().Trim() : string.Empty;
            BankKey.BANKA = null != reader[Constants.OUT_BANKA] ? reader[Constants.OUT_BANKA].ToString().Trim() : string.Empty;

            return BankKey;
        }
    }
}

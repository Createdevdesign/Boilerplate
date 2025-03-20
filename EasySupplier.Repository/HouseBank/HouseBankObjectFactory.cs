using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    internal class HouseBankObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster HouseBank = new SAPMaster();

            HouseBank.MANDT = null != reader[Constants.OUT_MANDT] ? Convert.ToInt32(reader[Constants.OUT_MANDT].ToString().Trim()) : 0;
            HouseBank.HBKID = null != reader[Constants.OUT_HBKID] ? reader[Constants.OUT_HBKID].ToString().Trim() : string.Empty;
            HouseBank.BANKL = null != reader[Constants.OUT_BANKL] ? reader[Constants.OUT_BANKL].ToString().Trim() : string.Empty;

            return HouseBank;
        }
    }
}

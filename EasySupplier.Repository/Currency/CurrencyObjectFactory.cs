using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    

    internal class CurrencyObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster Currency = new SAPMaster();

            Currency.MANDT = null != reader[Constants.OUT_MANDT] ? Convert.ToInt32(reader[Constants.OUT_MANDT].ToString().Trim()) : 0;
            Currency.WAERS = null != reader[Constants.OUT_WAERS] ? reader[Constants.OUT_WAERS].ToString().Trim() : string.Empty;
            Currency.LTEXT = null != reader[Constants.OUT_LTEXT] ? reader[Constants.OUT_LTEXT].ToString().Trim() : string.Empty;

            return Currency;
        }
    }
}

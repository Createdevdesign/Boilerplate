using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   
    internal class WithholdingTaxCountryObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster WithholdingTaxCountry = new SAPMaster();

            WithholdingTaxCountry.MANDT = null != reader[Constants.OUT_MANDT] ? Convert.ToInt32(reader[Constants.OUT_MANDT].ToString().Trim()) : 0;
            WithholdingTaxCountry.QLAND = null != reader[Constants.OUT_QLAND] ? reader[Constants.OUT_QLAND].ToString().Trim() : string.Empty;
            WithholdingTaxCountry.QLTXT = null != reader[Constants.OUT_QLTXT] ? reader[Constants.OUT_QLTXT].ToString().Trim() : string.Empty;

            return WithholdingTaxCountry;
        }
    }
}

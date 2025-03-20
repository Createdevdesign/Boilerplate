using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
  
    internal class SectionCodeObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster SectionCode = new SAPMaster();

            SectionCode.MANDT = null != reader[Constants.OUT_MANDT] ? Convert.ToInt32(reader[Constants.OUT_MANDT].ToString().Trim()) : 0;
            SectionCode.BUKRS = null != reader[Constants.OUT_BUKRS] ? Convert.ToInt32(reader[Constants.OUT_BUKRS].ToString().Trim()) : 0;
            SectionCode.FIWTIN_SECOG = null != reader[Constants.OUT_FIWTIN_SECOG] ? reader[Constants.OUT_FIWTIN_SECOG].ToString().Trim() : string.Empty;

            return SectionCode;
        }
    }
}

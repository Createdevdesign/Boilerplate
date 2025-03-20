using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    internal class ReconciliationAccountObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster ReconciliationAccount = new SAPMaster();

            ReconciliationAccount.BUKRS = null != reader[Constants.OUT_BUKRS] ? Convert.ToInt32(reader[Constants.OUT_BUKRS].ToString().Trim()) : 0;
            ReconciliationAccount.SAKNR = null != reader[Constants.OUT_SAKNR] ? reader[Constants.OUT_SAKNR].ToString().Trim() : string.Empty;
            ReconciliationAccount.TXT50 = null != reader[Constants.OUT_TXT50] ? reader[Constants.OUT_TXT50].ToString().Trim() : string.Empty;

            return ReconciliationAccount;
        }
    }
}

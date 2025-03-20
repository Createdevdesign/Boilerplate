using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    internal class TypeOfRecipientObjectFactory : IDomainObjectFactory<SAPMaster>
    {
        public SAPMaster Construct(IDataReader reader)
        {
            SAPMaster TypeOfRecipient = new SAPMaster();

            TypeOfRecipient.MANDT = null != reader[Constants.OUT_MANDT] ? Convert.ToInt32(reader[Constants.OUT_MANDT].ToString().Trim()) : 0;
            TypeOfRecipient.LAND1 = null != reader[Constants.OUT_LAND1] ? reader[Constants.OUT_LAND1].ToString().Trim() : string.Empty;
            TypeOfRecipient.QSREC = null != reader[Constants.OUT_QSREC] ? reader[Constants.OUT_QSREC].ToString().Trim() : string.Empty;

            return TypeOfRecipient;
        }
    }
}

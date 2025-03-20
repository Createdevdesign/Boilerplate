using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   
    internal class FileMasterObjectFactory : IDomainObjectFactory<FileMaster>
    {
        public FileMaster Construct(IDataReader reader)
        {
            FileMaster FileMaster = new FileMaster();

            //LookupValue.CodeType = null != reader[Constants.OUT_CODE_TYPE] ? Convert.ToInt32(reader[Constants.OUT_CODE_TYPE].ToString().Trim()) : 0;
            //LookupValue.CodeTypeDesc = null != reader[Constants.OUT_CODE_TYPE_DESC] ? reader[Constants.OUT_CODE_TYPE_DESC].ToString().Trim() : string.Empty;
            //LookupValue.CodeSec = DBNull.Value != reader[Constants.OUT_CODE_SEC_YN_ID] ? Convert.ToBoolean(reader[Constants.OUT_CODE_SEC_YN_ID].ToString().Trim()) : false;
            //LookupValue.TypeOfLookupValue = null != reader[Constants.OUT_TYPE_OF_LookupValue_MASTER_ID] ? reader[Constants.OUT_TYPE_OF_LookupValue_MASTER_ID].ToString().Trim() : string.Empty;
            //LookupValue.Remarks = null != reader[Constants.OUT_REMARKS] ? reader[Constants.OUT_REMARKS].ToString().Trim() : string.Empty;

            return FileMaster;
        }
    }
}

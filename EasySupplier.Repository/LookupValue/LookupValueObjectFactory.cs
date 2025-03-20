using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;


namespace BoilerSupplier.Repository
{
    
    internal class LookupValueObjectFactory : IDomainObjectFactory<LookupValue>
    {
        public LookupValue Construct(IDataReader reader)
        {
            LookupValue LookupValue = new LookupValue();

            LookupValue.CodeType = null != reader[Constants.OUT_CODE_TYPE] ? Convert.ToInt32(reader[Constants.OUT_CODE_TYPE].ToString().Trim()) : 0;

            //LookupValue.Code = null != reader[Constants.OUT_LOOKUP_MASTER_NAME] ? reader[Constants.OUT_LOOKUP_MASTER_NAME].ToString().Trim() : string.Empty;
            //LookupValue.Code = null != reader[Constants.OUT_LOOKUP_VALUE_CODE] ? Convert.ToInt32(reader[Constants.OUT_LOOKUP_VALUE_CODE].ToString().Trim()) : 0;
            LookupValue.RefCode = null != reader[Constants.OUT_REF_CODE] ? reader[Constants.OUT_REF_CODE].ToString().Trim() : string.Empty;
            LookupValue.CodeDesc = null != reader[Constants.OUT_CODE_DESC] ? reader[Constants.OUT_CODE_DESC].ToString().Trim() : string.Empty;
            
            //LookupValue.Remarks = null != reader[Constants.OUT_REMARKS] ? reader[Constants.OUT_REMARKS].ToString().Trim() : string.Empty;              
           
            //LookupValue.SecYN = DBNull.Value != reader[Constants.OUT_LOOKUP_MASTER_SEC_YN] ? Convert.ToBoolean(reader[Constants.OUT_LOOKUP_MASTER_SEC_YN].ToString().Trim()) : false;
          
            return LookupValue;
        }
    }
}

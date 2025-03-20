using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
  
    internal class OperationalConfigrationObjectFactory : IDomainObjectFactory<OperationalConfigrationMaster>
    {
        public OperationalConfigrationMaster Construct(IDataReader reader)
        {
            OperationalConfigrationMaster OperationalConfigrationMaster = new OperationalConfigrationMaster();

            OperationalConfigrationMaster.ConfigurationDescription = null != reader[Constants.OUT_CONFIGURATION_DESCRIPTION] ? reader[Constants.OUT_CONFIGURATION_DESCRIPTION].ToString().Trim() : string.Empty;
            OperationalConfigrationMaster.ConfigurationName = null != reader[Constants.OUT_CONFIGURATION_NAME] ? reader[Constants.OUT_CONFIGURATION_NAME].ToString().Trim() : string.Empty;
            OperationalConfigrationMaster.Configcategory = null != reader[Constants.OUT_CONFIG_CATEGORY] ? Convert.ToDecimal(reader[Constants.OUT_CONFIG_CATEGORY].ToString().Trim()) : 0;
            OperationalConfigrationMaster.ConfigType = null != reader[Constants.OUT_CONFIG_TYPE] ? Convert.ToDecimal(reader[Constants.OUT_CONFIG_TYPE].ToString().Trim()) : 0;
            OperationalConfigrationMaster.ConfigValueType = null != reader[Constants.OUT_CONFIG_VALUE_TYPE] ? Convert.ToDecimal(reader[Constants.OUT_CONFIG_VALUE_TYPE].ToString().Trim()) : 0;
            OperationalConfigrationMaster.Remarks = null != reader[Constants.OUT_REMARKS] ? reader[Constants.OUT_REMARKS].ToString().Trim() : string.Empty;
            OperationalConfigrationMaster.Configvalue = DBNull.Value != reader[Constants.OUT_CONFIG_VALUE] ? Convert.ToBoolean(reader[Constants.OUT_CONFIG_VALUE].ToString().Trim()) : false;
            OperationalConfigrationMaster.AppDesc = null != reader[Constants.OUT_APP_DESC] ? Convert.ToDecimal(reader[Constants.OUT_APP_DESC].ToString().Trim()) : 0;

            OperationalConfigrationMaster.Updatedby = null != reader[Constants.OUT_UPDATED_BY] ? reader[Constants.OUT_UPDATED_BY].ToString().Trim() : string.Empty;
            OperationalConfigrationMaster.Submerchantname = null != reader[Constants.OUT_SUB_MERCHANT_NAME] ? reader[Constants.OUT_SUB_MERCHANT_NAME].ToString().Trim() : string.Empty;
            OperationalConfigrationMaster.MerchantName = null != reader[Constants.OUT_MERCHANT_NAME] ? reader[Constants.OUT_MERCHANT_NAME].ToString().Trim() : string.Empty;
            OperationalConfigrationMaster.updateddate = null != reader[Constants.OUT_UPDATED_DATE] ? Convert.ToDateTime(reader[Constants.OUT_UPDATED_DATE].ToString().Trim()) : DateTime.Today;

            return OperationalConfigrationMaster;
        }
    }
}

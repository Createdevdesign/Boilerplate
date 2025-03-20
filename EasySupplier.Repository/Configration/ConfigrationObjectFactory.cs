using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    internal class ConfigrationObjectFactory : IDomainObjectFactory<ConfigrationMaster>
    {
        public ConfigrationMaster Construct(IDataReader reader)
        {
            ConfigrationMaster ConfigrationMaster = new ConfigrationMaster();

            ConfigrationMaster.ConfigurationDescription = null != reader[Constants.OUT_CONFIGURATION_DESCRIPTION] ? reader[Constants.OUT_CONFIGURATION_DESCRIPTION].ToString().Trim() : string.Empty;
            ConfigrationMaster.ConfigurationName = null != reader[Constants.OUT_CONFIGURATION_NAME] ? reader[Constants.OUT_CONFIGURATION_NAME].ToString().Trim() : string.Empty;
            
            ConfigrationMaster.Configcategory = null != reader[Constants.OUT_CONFIG_CATEGORY] ? Convert.ToDecimal(reader[Constants.OUT_CONFIG_CATEGORY].ToString().Trim()) : 0;
            ConfigrationMaster.ConfigType = null != reader[Constants.OUT_CONFIG_TYPE] ? Convert.ToDecimal(reader[Constants.OUT_CONFIG_TYPE].ToString().Trim()) : 0;
            ConfigrationMaster.ConfigValueType = null != reader[Constants.OUT_CONFIG_VALUE_TYPE] ? Convert.ToDecimal(reader[Constants.OUT_CONFIG_VALUE_TYPE].ToString().Trim()) : 0;

            ConfigrationMaster.Remarks = null != reader[Constants.OUT_REMARKS] ? reader[Constants.OUT_REMARKS].ToString().Trim() : string.Empty;
            ConfigrationMaster.Configvalue = DBNull.Value != reader[Constants.OUT_CONFIG_VALUE] ? Convert.ToBoolean(reader[Constants.OUT_CONFIG_VALUE].ToString().Trim()) : false;
            ConfigrationMaster.AppDesc = null != reader[Constants.OUT_APP_DESC] ? Convert.ToDecimal(reader[Constants.OUT_APP_DESC].ToString().Trim()) : 0;
          
           
            return ConfigrationMaster;
        }
    }
}

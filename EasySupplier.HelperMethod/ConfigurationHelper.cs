using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace BoilerSupplier.HelperMethod
{
    public class ConfigurationHelper
    {
        #region Public Methods

        /// <summary>
        /// Gets the file configuration value.
        /// </summary>
        /// <param name="keyName">Name of the key.</param>
        /// <returns></returns>
        public static string GetFileConfigurationValue(string keyName)
        {
            string configValue = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(keyName))
                {
                    configValue = ConfigurationManager.AppSettings.Get(keyName);
                }
            }
            catch (Exception ex)
            {
                configValue = string.Empty;
                //SystemLogs.LogException(ex);
            }

            return configValue;
        }

        public static string GetConnectionString(string connectionStringName)
        {
            string connectionString = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(connectionStringName))
                {
                    connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ToString();
                }
            }
            catch (Exception ex)
            {
                connectionString = string.Empty;
               // SystemLogs.LogException(ex);
            }

            return connectionString;
        }

        #endregion Public Methods
    }
}

using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
 
    internal class ConfigrationSelectFactory : ISelectionFactory<ConfigrationMaster>
    {
        public IDbCommand ConstructSelectCommand(ConfigrationMaster idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            sqlCommand.Parameters.Add(Constants.PN_CONFIG_ID, SqlDbType.Decimal, 18).Value = idObject.Configid;   
            sqlCommand.Parameters.Add(Constants.PS_CONFIGURATION_DESCRIPTION, SqlDbType.NVarChar, 200).Value = idObject.ConfigurationDescription;
            sqlCommand.Parameters.Add(Constants.PS_CONFIGURATION_NAME, SqlDbType.NVarChar, 200).Value = idObject.ConfigurationName;
            sqlCommand.Parameters.Add(Constants.PN_CONFIG_CATEGORY, SqlDbType.Decimal, 18).Value = idObject.Configcategory;
            sqlCommand.Parameters.Add(Constants.PN_CONFIG_TYPE, SqlDbType.Decimal, 18).Value = idObject.ConfigType;
           
            sqlCommand.Parameters.Add(Constants.PN_CONFIG_VALUE_TYPE, SqlDbType.Decimal, 18).Value = idObject.ConfigValueType;
            sqlCommand.Parameters.Add(Constants.PS_REMARKS, SqlDbType.NVarChar, 1000).Value = idObject.Remarks;
            sqlCommand.Parameters.Add(Constants.PS_CONFIG_VALUE, SqlDbType.Bit, 5).Value = idObject.Configvalue;
            sqlCommand.Parameters.Add(Constants.PN_APP_DESC, SqlDbType.Decimal, 18).Value = idObject.AppDesc;

            

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_CONFIGRATION_MASTER;
            return sqlCommand;
        }
    }
}

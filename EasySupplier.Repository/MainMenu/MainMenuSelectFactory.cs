using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
    
    internal class MainMenuSelectFactory : ISelectionFactory<MainMenu>
    {
        public IDbCommand ConstructSelectCommand(MainMenu idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            sqlCommand.Parameters.Add(Constants.PN_ID, SqlDbType.Int, 4).Value = idObject.Id;
            sqlCommand.Parameters.Add(Constants.PS_MAIN_MENU_NAME, SqlDbType.NVarChar, 100).Value = idObject.MainMenuName;
            sqlCommand.Parameters.Add(Constants.PN_MENU_ORDER, SqlDbType.Int, 4).Value = idObject.MenuOrder;
            sqlCommand.Parameters.Add(Constants.PN_SERVICES_ID, SqlDbType.Int, 4).Value = idObject.ServicesID;
            sqlCommand.Parameters.Add(Constants.PS_MODULE_NAME, SqlDbType.NVarChar, 200).Value = idObject.ModuleName;

            sqlCommand.Parameters.Add(Constants.PS_MODULE_ID, SqlDbType.NVarChar, 200).Value = idObject.ModuleId;
            sqlCommand.Parameters.Add(Constants.PS_ICON, SqlDbType.NVarChar, 100).Value = idObject.icon;    
            sqlCommand.Parameters.Add(Constants.PS_IS_ACTIVE_YN, SqlDbType.Bit, 5).Value = idObject.IsActive;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_MAIN_MENU;
            return sqlCommand;
        }
    }
}

using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
   
   
    internal class SubMenuSelectFactory : ISelectionFactory<SubMenu>
    {
        public IDbCommand ConstructSelectCommand(SubMenu idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            sqlCommand.Parameters.Add(Constants.PN_ID, SqlDbType.Int, 4).Value = idObject.ID;
            sqlCommand.Parameters.Add(Constants.PS_VAR_SCREEN_TITLE, SqlDbType.NVarChar, 100).Value = idObject.varScreenTitle;
            sqlCommand.Parameters.Add(Constants.PS_VAR_PAGE_NAME, SqlDbType.NVarChar, 100).Value = idObject.varPageName;
            sqlCommand.Parameters.Add(Constants.PN_MAIN_MENU_ID, SqlDbType.Int, 4).Value = idObject.MainMenuId;
            sqlCommand.Parameters.Add(Constants.PN_INTORDER_NO, SqlDbType.Decimal, 18).Value = idObject.Intorderno;
            
            sqlCommand.Parameters.Add(Constants.PN_SERVICES_ID, SqlDbType.Decimal, 18).Value = idObject.ServicesId;
            sqlCommand.Parameters.Add(Constants.PS_ANGULAR_URL, SqlDbType.NVarChar, 200).Value = idObject.AngularUrl;
            sqlCommand.Parameters.Add(Constants.PS_IS_ACTIVE_YN, SqlDbType.Bit, 5).Value = idObject.IsActive;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_SUB_MENU;
            return sqlCommand;
        }
    }
}

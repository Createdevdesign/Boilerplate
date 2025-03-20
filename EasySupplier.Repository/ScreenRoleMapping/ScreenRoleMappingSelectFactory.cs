using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
    


    internal class ScreenRoleMappingSelectFactory : ISelectionFactory<ScreenRoleMapping>
    {
        public IDbCommand ConstructSelectCommand(ScreenRoleMapping idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

           
            sqlCommand.Parameters.Add(Constants.PN_SUB_MENU_ID, SqlDbType.Int, 4).Value = idObject.SubMenuId;
            sqlCommand.Parameters.Add(Constants.PN_ROLE_ID, SqlDbType.Int, 4).Value = idObject.RoleId;
            sqlCommand.Parameters.Add(Constants.PN_SERVICES_ID, SqlDbType.Decimal, 18).Value = idObject.ServicesId;
            sqlCommand.Parameters.Add(Constants.PS_IS_ACTIVE_YN, SqlDbType.Bit, 5).Value = idObject.IsActive;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_SCREEN_ROLE_MAPPING;
            return sqlCommand;
        }
    }
}

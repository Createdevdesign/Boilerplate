using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
   
    internal class ModuleSelectFactory : ISelectionFactory<ModuleMaster>
    {
        public IDbCommand ConstructSelectCommand(ModuleMaster idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            sqlCommand.Parameters.Add(Constants.PN_ID, SqlDbType.Decimal, 18).Value = idObject.Id;
            sqlCommand.Parameters.Add(Constants.PS_MODULE_NAME, SqlDbType.NVarChar, 200).Value = idObject.ModuleName;
            sqlCommand.Parameters.Add(Constants.PN_SERVICES_ID, SqlDbType.Decimal, 18).Value = idObject.ServicesId;
            sqlCommand.Parameters.Add(Constants.PS_ICON, SqlDbType.NVarChar, 100).Value = idObject.icon;
            sqlCommand.Parameters.Add(Constants.PN_MODULE_ORDER, SqlDbType.Decimal, 18).Value = idObject.ModuleOrder;
            
            sqlCommand.Parameters.Add(Constants.PS_MODULE_ASSIGN, SqlDbType.NVarChar, 50).Value = idObject.ModuleAssign;
            sqlCommand.Parameters.Add(Constants.PS_IS_ACTIVE_YN, SqlDbType.Bit, 5).Value = idObject.IsActive;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_MODULE_MASTER;
            return sqlCommand;
        }
    }
}

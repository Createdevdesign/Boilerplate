using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
  
    internal class ModuleAssigmentSelectFactory : ISelectionFactory<Module_Assigment>
    {
        public IDbCommand ConstructSelectCommand(Module_Assigment idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            
            sqlCommand.Parameters.Add(Constants.PN_ACQ_ID, SqlDbType.Decimal, 18).Value = idObject.ACQ_ID;
            sqlCommand.Parameters.Add(Constants.PN_MODULE, SqlDbType.Decimal, 18).Value = idObject.Module;
            sqlCommand.Parameters.Add(Constants.PS_STATUS_YN, SqlDbType.Bit, 5).Value = idObject.Status;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_MODULE_ASSIGMENT;
            return sqlCommand;
        }
    }
}

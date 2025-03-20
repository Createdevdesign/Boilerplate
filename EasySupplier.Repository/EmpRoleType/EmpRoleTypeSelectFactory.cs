using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;
namespace BoilerSupplier.Repository
{
 
    internal class EmpRoleTypeSelectFactory : ISelectionFactory<EmpRole>
    {
        public IDbCommand ConstructSelectCommand(EmpRole idObject)
        {


            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            sqlCommand.Parameters.Add(Constants.PS_EmpLoginEmailID, SqlDbType.NVarChar, 50).Value = idObject.EmpLoginEmailID;
            sqlCommand.Parameters.Add(Constants.PS_ADLogin, SqlDbType.VarChar, 50).Value = idObject.ADLogin;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_GET_EMP_ROLE_TYPE;
            return sqlCommand;
        }
    }
}

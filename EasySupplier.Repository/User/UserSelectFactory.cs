using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
    
    internal class UserSelectFactory : ISelectionFactory<User>
    {
        public IDbCommand ConstructSelectCommand(User idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            //sqlCommand.Parameters.Add(Constants.PN_ID, SqlDbType.Decimal, 18).Value = idObject.Id;
            sqlCommand.Parameters.Add(Constants.PN_USER_ROLE, SqlDbType.Decimal, 18).Value = idObject.UserRole;
            sqlCommand.Parameters.Add(Constants.PS_USER_NAME, SqlDbType.NVarChar, 500).Value = idObject.UserName;
            sqlCommand.Parameters.Add(Constants.PN_MOBILE_NO, SqlDbType.Decimal, 18).Value = idObject.MobileNo;
            sqlCommand.Parameters.Add(Constants.PS_EMAIL_ID, SqlDbType.NVarChar, 500).Value = idObject.EmailId;
            sqlCommand.Parameters.Add(Constants.PS_PASSWORD, SqlDbType.NVarChar, 500).Value = idObject.Password;
            sqlCommand.Parameters.Add(Constants.PS_USER_ID, SqlDbType.NVarChar, 500).Value = idObject.UserId;
            sqlCommand.Parameters.Add(Constants.PS_ACTIVE, SqlDbType.NChar, 1).Value = idObject.Active;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_USER;
            return sqlCommand;
        }
    }
}

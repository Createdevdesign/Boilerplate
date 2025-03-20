using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
    internal class LoginSelectFactory : ISelectionFactory<User>
    {
        public IDbCommand ConstructSelectCommand(User idObject)
        {
            //SqlCommand sqlCommand = new SqlCommand();
            //sqlCommand.Parameters.Add(Constants.IN_USER_ID, SqlDbType.NVarChar, 50).Value = idObject.UserId;
            //sqlCommand.Parameters.Add(Constants.IN_PASSWORD, SqlDbType.NVarChar, 50).Value = idObject.PasswordHash;
            //sqlCommand.Parameters.Add(Constants.OUT_USER_EXISTS, SqlDbType.NVarChar, 1).Direction = ParameterDirection.Output;
            //sqlCommand.Parameters.Add(Constants.OUT_USER_NAME, SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
            //sqlCommand.Parameters.Add(Constants.OUT_USER_PASSWORD, SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
            //sqlCommand.Parameters.Add(Constants.OUT_USER_LOCK, SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            //sqlCommand.CommandText = Constants.USP_LOGIN_CREDENTIALS_VERIFICATION;
            //return sqlCommand;


            //SqlCommand sqlCommand = new SqlCommand();
            //sqlCommand.Parameters.Add(Constants.IN_Email_Address, SqlDbType.NVarChar, 50).Value = idObject.EmailAddress;
            //sqlCommand.Parameters.Add(Constants.IN_Preferred_User_ID, SqlDbType.NVarChar, 50).Value = idObject.PreferredUserID;
            //sqlCommand.Parameters.Add(Constants.IN_PASSWORD, SqlDbType.NVarChar, 500).Value = idObject.Password;
            //sqlCommand.Parameters.Add(Constants.OUT_USER_EXISTS, SqlDbType.NVarChar, 1).Direction = ParameterDirection.Output;
            //sqlCommand.Parameters.Add(Constants.OUT_USER_NAME, SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
            //sqlCommand.Parameters.Add(Constants.OUT_USER_PASSWORD, SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
            //sqlCommand.Parameters.Add(Constants.OUT_USER_LOCK, SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            //sqlCommand.CommandText = Constants.USP_LOGIN_CREDENTIALS_VERIFICATION;
            //return sqlCommand;

            //26-7-2021
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            sqlCommand.Parameters.Add(Constants.PS_Email_Address, SqlDbType.NVarChar, 50).Value = idObject.EmailAddress;
            sqlCommand.Parameters.Add(Constants.PS_PASSWORD, SqlDbType.NVarChar, 500).Value = idObject.Password;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_LOGIN_CHECK;
            return sqlCommand;
        }
    }
}

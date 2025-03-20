using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
   
    internal class SignupSelectFactory : ISelectionFactory<Signup>
    {
        public IDbCommand ConstructSelectCommand(Signup idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;


            sqlCommand.Parameters.Add(Constants.PS_FIRST_NAME, SqlDbType.VarChar, 50).Value = idObject.FirstName;
            sqlCommand.Parameters.Add(Constants.PS_LAST_NAME, SqlDbType.VarChar, 50).Value = idObject.LastName;
            sqlCommand.Parameters.Add(Constants.PS_DESIGNATION, SqlDbType.NVarChar, 50).Value = idObject.Designation;
            sqlCommand.Parameters.Add(Constants.PS_MOBILE_NO, SqlDbType.VarChar, 20).Value = idObject.MobileNo;
            sqlCommand.Parameters.Add(Constants.PS_EMAIL_ADDRESS, SqlDbType.NVarChar, 50).Value = idObject.EmailAddress;
            //sqlCommand.Parameters.Add(Constants.PS_OTP, SqlDbType.VarChar, 10).Value = idObject.OTP;
            sqlCommand.Parameters.Add(Constants.PS_PREFERRED_USER_ID, SqlDbType.NVarChar, 50).Value = idObject.PreferredUserID;
            sqlCommand.Parameters.Add(Constants.PS_PASSWORD, SqlDbType.NVarChar, 500).Value = idObject.Password;
            
           

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_SIGNUP;
            return sqlCommand;
        }
    }
}

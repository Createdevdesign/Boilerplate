using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
  

    internal class ReferencesSelectFactory : ISelectionFactory<References>
    {
        public IDbCommand ConstructSelectCommand(References idObject)
        {

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            //sqlCommand.Parameters.Add(Constants.PN_TAB_INDEX, SqlDbType.Int, 4).Value = idObject.TabIndex;
            sqlCommand.Parameters.Add(Constants.PS_LOGIN_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.LoginEmailID;
            
            //References
            sqlCommand.Parameters.Add(Constants.PS_REF_CUSTOMERS_NAME, SqlDbType.VarChar, 50).Value = idObject.RefCustomersName;
            sqlCommand.Parameters.Add(Constants.PS_REF_CONTACT_PERSON, SqlDbType.VarChar, 50).Value = idObject.RefContactPerson;
            sqlCommand.Parameters.Add(Constants.PS_REF_DESIGNATION, SqlDbType.VarChar, 50).Value = idObject.RefDesignation;
            sqlCommand.Parameters.Add(Constants.PS_REF_CONTACT_NO, SqlDbType.VarChar, 50).Value = idObject.RefContactNo;
            sqlCommand.Parameters.Add(Constants.PS_REF_EMAIL_ID, SqlDbType.NVarChar, 50).Value = idObject.RefEmailID;

          

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_REFERENCES;
            return sqlCommand;
        }
    }
}

using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
   

    internal class InviteSupplierSelectFactory : ISelectionFactory<InviteSupplier>
    {
        public IDbCommand ConstructSelectCommand(InviteSupplier idObject)
        {


            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;
            sqlCommand.Parameters.Add(Constants.PS_PUR_ORG_CODE, SqlDbType.VarChar, 10).Value = idObject.PurOrgCode;
            sqlCommand.Parameters.Add(Constants.PS_FIRST_NAME, SqlDbType.VarChar, 50).Value = idObject.FirstName;
            sqlCommand.Parameters.Add(Constants.PS_LAST_NAME, SqlDbType.VarChar, 50).Value = idObject.LastName;
            sqlCommand.Parameters.Add(Constants.PS_COMPANY_NAME, SqlDbType.NVarChar, 100).Value = idObject.CompanyName;
            sqlCommand.Parameters.Add(Constants.PS_CONTACT_NO, SqlDbType.VarChar, 20).Value = idObject.ContactNo;
            sqlCommand.Parameters.Add(Constants.PS_EMAIL_ADDRESS, SqlDbType.NVarChar, 50).Value = idObject.EmailAddress;
            sqlCommand.Parameters.Add(Constants.PS_INVITED_BY, SqlDbType.NVarChar, 50).Value = idObject.Invitedby;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_INVITE_SUPPLIER;
            return sqlCommand;
        }
    }
}

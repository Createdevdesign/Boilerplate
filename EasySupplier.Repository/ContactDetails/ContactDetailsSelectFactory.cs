using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
   
    internal class ContactDetailsSelectFactory : ISelectionFactory<ContactDetail>
    {
        public IDbCommand ConstructSelectCommand(ContactDetail idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            //sqlCommand.Parameters.Add(Constants.PN_JURIS_ORG_CODE, SqlDbType.Decimal, 18).Value = idObject.Id;
            sqlCommand.Parameters.Add(Constants.PN_PHONE_NUMBER, SqlDbType.Decimal, 18).Value = idObject.PhoneNumber;
            sqlCommand.Parameters.Add(Constants.PS_PHONE_NUMBER_TYPE, SqlDbType.NVarChar, 50).Value = idObject.PhoneNumberType;
            sqlCommand.Parameters.Add(Constants.PS_EMAIL_ADDRESS, SqlDbType.NVarChar, 50).Value = idObject.EmailAddress;
            sqlCommand.Parameters.Add(Constants.PS_USER_CODE, SqlDbType.NVarChar, 200).Value = idObject.UserCode;
            sqlCommand.Parameters.Add(Constants.PS_IS_ACTIVE_YN, SqlDbType.Bit, 5).Value = idObject.IsActive;
           
            sqlCommand.Parameters.Add(Constants.PS_ENTITY_TYPE, SqlDbType.Char, 1).Value = idObject.Entitytype;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_CONTACT_DETAILS;
            return sqlCommand;
        }
    }
}

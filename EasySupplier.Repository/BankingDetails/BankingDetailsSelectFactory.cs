using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
   
    internal class BankingDetailsSelectFactory : ISelectionFactory<BankingDetail>
    {
        public IDbCommand ConstructSelectCommand(BankingDetail idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            //sqlCommand.Parameters.Add(Constants.PN_ID, SqlDbType.Decimal, 18).Value = idObject.id;
           
            sqlCommand.Parameters.Add(Constants.PS_MERCHANT_ID, SqlDbType.NVarChar, 45).Value = idObject.merchantid;
            sqlCommand.Parameters.Add(Constants.PS_ACCOUNT_NUMBER, SqlDbType.NVarChar, 45).Value = idObject.accountnumber;
            sqlCommand.Parameters.Add(Constants.PS_ACC_TYPE, SqlDbType.NVarChar, 100).Value = idObject.acctype;
            sqlCommand.Parameters.Add(Constants.PS_IFSC_CODE, SqlDbType.NVarChar, 45).Value = idObject.ifsccode;
            sqlCommand.Parameters.Add(Constants.PN_BANK_ID, SqlDbType.Decimal, 18).Value = idObject.bankid;

            sqlCommand.Parameters.Add(Constants.PS_VALID_FROM, SqlDbType.DateTime, 100).Value = idObject.Validfrom;
            sqlCommand.Parameters.Add(Constants.PS_VALID_TO, SqlDbType.DateTime, 100).Value = idObject.ValidTo;
            sqlCommand.Parameters.Add(Constants.PS_IS_ACTIVE_YN, SqlDbType.Bit, 5).Value = idObject.Isactive;
            sqlCommand.Parameters.Add(Constants.PS_CHEQUE_DETAILS, SqlDbType.Image, 500).Value = idObject.ChequeDetails;
            sqlCommand.Parameters.Add(Constants.PS_ENTITY_TYPE, SqlDbType.Char, 1).Value = idObject.Entitytype;
    

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_BANKING_DETAILS;
            return sqlCommand;
        }
    }
}

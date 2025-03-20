using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
    
    internal class EmailFormatMappingSelectFactory : ISelectionFactory<EmailFormatMapping>
    {
        public IDbCommand ConstructSelectCommand(EmailFormatMapping idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            //sqlCommand.Parameters.Add(Constants.PN_RELATION_ID, SqlDbType.Decimal, 18).Value = idObject.Relation_ID;
            sqlCommand.Parameters.Add(Constants.PN_ACQ_ID, SqlDbType.Decimal, 18).Value = idObject.ACQ_id;
            sqlCommand.Parameters.Add(Constants.PN_FORMAT, SqlDbType.Decimal, 18).Value = idObject.Format;
            sqlCommand.Parameters.Add(Constants.PS_FORMAT_TEXT, SqlDbType.NVarChar, 1000).Value = idObject.Format_Text;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_EMAIL_FORMAT_MAPPING;
            return sqlCommand;
        }
    }
}

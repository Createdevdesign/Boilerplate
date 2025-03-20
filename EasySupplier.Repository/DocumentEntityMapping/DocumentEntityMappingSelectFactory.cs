using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
   
    internal class DocumentEntityMappingSelectFactory : ISelectionFactory<DocumentEntityMapping>
    {
        public IDbCommand ConstructSelectCommand(DocumentEntityMapping idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            
            sqlCommand.Parameters.Add(Constants.PS_ENTITY_CODE, SqlDbType.NVarChar, 45).Value = idObject.entitycode;
            sqlCommand.Parameters.Add(Constants.PN_DOCUMENT, SqlDbType.Decimal, 18).Value = idObject.Document;              
            sqlCommand.Parameters.Add(Constants.PS_MANDATORY_YN, SqlDbType.Bit, 5).Value = idObject.Mandatory;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_DOCUMENT_ENTITY_MAPPING;
            return sqlCommand;
        }
    }
}

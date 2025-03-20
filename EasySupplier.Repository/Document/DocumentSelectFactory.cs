using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
   
    internal class DocumentSelectFactory : ISelectionFactory<Document>
    {
        public IDbCommand ConstructSelectCommand(Document idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            //sqlCommand.Parameters.Add(Constants.PN_RELATION_ID, SqlDbType.Decimal, 18).Value = idObject.Relation_ID;
            //sqlCommand.Parameters.Add(Constants.PN_ENTITY_TYPE, SqlDbType.Decimal, 18).Value = idObject.entitytype;
            //sqlCommand.Parameters.Add(Constants.PS_DOCUMENT_NAME, SqlDbType.NVarChar,500).Value = idObject.DocumentName;

            sqlCommand.Parameters.Add(Constants.PN_COUNTRY_ID, SqlDbType.Int, 4).Value = idObject.countryID;
            sqlCommand.Parameters.Add(Constants.PS_DOCUMENT_NAME, SqlDbType.VarChar, 100).Value = idObject.Document_Name;
            sqlCommand.Parameters.Add(Constants.PS_MANDATORY_YN, SqlDbType.Bit,4).Value = idObject.Mandatory;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;

            //sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_DOCUMENT;

            sqlCommand.CommandText = Constants.USP_GET_COUNTRY_BASE_DOCUMENT;

            return sqlCommand;
        }
    }
}

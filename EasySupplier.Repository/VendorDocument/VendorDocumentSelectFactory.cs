using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;


namespace BoilerSupplier.Repository
{
    internal class VendorDocumentSelectFactory : ISelectionFactory<VendorDocument>
    {
        public IDbCommand ConstructSelectCommand(VendorDocument idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            sqlCommand.Parameters.Add(Constants.PS_VENDOR_CODE, SqlDbType.VarChar, 10).Value = idObject.Vendor_Code;
            sqlCommand.Parameters.Add(Constants.PS_DOCUMENT_TYPE, SqlDbType.VarChar, 10).Value = idObject.Document_Type;
            sqlCommand.Parameters.Add(Constants.PS_DOCUMENT_NAME, SqlDbType.NVarChar, 100).Value = idObject.Document_Name;
            sqlCommand.Parameters.Add(Constants.PS_EXPIRY_DATE, SqlDbType.DateTime, 50).Value = idObject.Expiry_Date;
            sqlCommand.Parameters.Add(Constants.PS_DOCUMENT_PATH, SqlDbType.NVarChar,500).Value = idObject.Document_Path;



            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_VENDOR_DOCUMENT;

            

            return sqlCommand;
        }
    }
}

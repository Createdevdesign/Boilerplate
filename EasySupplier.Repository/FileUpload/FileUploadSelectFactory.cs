using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
    

    internal class FileUploadSelectFactory : ISelectionFactory<FileUpload>
    {
        public IDbCommand ConstructSelectCommand(FileUpload idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            sqlCommand.Parameters.Add(Constants.PS_TRANSACTION_HEADER_ID, SqlDbType.VarChar, 30).Value = idObject.VendorCode;
            sqlCommand.Parameters.Add(Constants.PS_FILE_ID, SqlDbType.NVarChar, 200).Value = idObject.FileName;
            sqlCommand.Parameters.Add(Constants.PS_DESTINATION_AGENCY, SqlDbType.VarBinary, 1000).Value = idObject.FileUploaded;
            sqlCommand.Parameters.Add(Constants.PS_MERCHANT_ID, SqlDbType.VarChar, 50).Value = idObject.FileType;
            sqlCommand.Parameters.Add(Constants.PS_TRANSACTION_HEADER_ID, SqlDbType.VarChar, 50).Value = idObject.Size;

            sqlCommand.Parameters.Add(Constants.PS_FILE_ID, SqlDbType.VarChar, 1000).Value = idObject.FilePath;
            sqlCommand.Parameters.Add(Constants.PS_DESTINATION_AGENCY, SqlDbType.VarChar, 50).Value = idObject.DocType;
            sqlCommand.Parameters.Add(Constants.PS_MERCHANT_ID, SqlDbType.VarChar, 50).Value = idObject.DocName;
            sqlCommand.Parameters.Add(Constants.PS_TRANSACTION_HEADER_ID, SqlDbType.DateTime, 100).Value = idObject.ExpiryDate;
            sqlCommand.Parameters.Add(Constants.PS_FILE_ID, SqlDbType.Bit,5).Value = idObject.IsMandatory;

            sqlCommand.Parameters.Add(Constants.PS_DESTINATION_AGENCY, SqlDbType.NVarChar, 50).Value = idObject.LoginEmailId;
            sqlCommand.Parameters.Add(Constants.PS_MERCHANT_ID, SqlDbType.Bit, 5).Value = idObject.Flag;



            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_FILE_SCHEMA;
            return sqlCommand;
        }
    }
}

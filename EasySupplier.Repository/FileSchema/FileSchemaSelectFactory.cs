using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
  

    internal class FileSchemaSelectFactory : ISelectionFactory<FileSchema>
    {
        public IDbCommand ConstructSelectCommand(FileSchema idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            sqlCommand.Parameters.Add(Constants.PN_ID, SqlDbType.Decimal, 18).Value = idObject.id;
            sqlCommand.Parameters.Add(Constants.PS_TRANSACTION_HEADER_ID, SqlDbType.NVarChar, 200).Value = idObject.TransactionHeaderid;
            sqlCommand.Parameters.Add(Constants.PS_FILE_ID, SqlDbType.NVarChar, 200).Value = idObject.FileID;
            sqlCommand.Parameters.Add(Constants.PS_DESTINATION_AGENCY, SqlDbType.NVarChar, 200).Value = idObject.DestinationAgency;
            sqlCommand.Parameters.Add(Constants.PS_MERCHANT_ID, SqlDbType.NVarChar, 200).Value = idObject.Merchantid;
            
            sqlCommand.Parameters.Add(Constants.PS_SUB_MERCHANT_ID, SqlDbType.NVarChar, 200).Value = idObject.Submerchantid;
            sqlCommand.Parameters.Add(Constants.PS_FILE_TYPE_ID, SqlDbType.NVarChar, 200).Value = idObject.Filetypeid;
            sqlCommand.Parameters.Add(Constants.PS_FILE_NAME, SqlDbType.NVarChar, 200).Value = idObject.Filename;
            sqlCommand.Parameters.Add(Constants.PN_FILE_STATUS, SqlDbType.Int, 4).Value = idObject.Filestatus;
            sqlCommand.Parameters.Add(Constants.PS_SOURCE, SqlDbType.NVarChar, 200).Value = idObject.Source;
            
            sqlCommand.Parameters.Add(Constants.PS_DESTINATION, SqlDbType.NVarChar, 200).Value = idObject.Destination;
            sqlCommand.Parameters.Add(Constants.PS_BACKUP_PATH, SqlDbType.NVarChar, 200).Value = idObject.BackupPath;
            sqlCommand.Parameters.Add(Constants.PS_NO_OF_RECORDS, SqlDbType.NVarChar, 200).Value = idObject.NoofRecords;
            sqlCommand.Parameters.Add(Constants.PS_SUCCESSFULL_PROCESS_RECORD, SqlDbType.NVarChar, 200).Value = idObject.SuccessfullProcessRecord;
            sqlCommand.Parameters.Add(Constants.PS_UNSUCCESSFULL__RECORDS, SqlDbType.NVarChar, 200).Value = idObject.UnsuccessfullRecord;
            
            sqlCommand.Parameters.Add(Constants.PS_REMARKS, SqlDbType.NVarChar, 200).Value = idObject.Remarks;
         
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

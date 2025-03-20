using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;


namespace BoilerSupplier.Repository
{
   

    internal class FileSchemaObjectFactory : IDomainObjectFactory<FileSchema>
    {
        public FileSchema Construct(IDataReader reader)
        {
            FileSchema FileSchema = new FileSchema();

            FileSchema.TransactionHeaderid = null != reader[Constants.OUT_TRANSACTION_HEADER_ID] ? reader[Constants.OUT_TRANSACTION_HEADER_ID].ToString().Trim() : string.Empty;
            FileSchema.FileID = null != reader[Constants.OUT_FILE_ID] ? reader[Constants.OUT_FILE_ID].ToString().Trim() : string.Empty;
            FileSchema.DestinationAgency = null != reader[Constants.OUT_DESTINATION_AGENCY] ? reader[Constants.OUT_DESTINATION_AGENCY].ToString().Trim() : string.Empty;
            FileSchema.Merchantid = null != reader[Constants.OUT_MERCHANT_ID] ? reader[Constants.OUT_MERCHANT_ID].ToString().Trim() : string.Empty;
            FileSchema.Submerchantid = null != reader[Constants.OUT_SUB_MERCHANT_ID] ? reader[Constants.OUT_SUB_MERCHANT_ID].ToString().Trim() : string.Empty;
            FileSchema.Filetypeid = null != reader[Constants.OUT_FILE_TYPE_ID] ? reader[Constants.OUT_FILE_TYPE_ID].ToString().Trim() : string.Empty;
            FileSchema.Filename = null != reader[Constants.OUT_FILE_NAME] ? reader[Constants.OUT_FILE_NAME].ToString().Trim() : string.Empty;
            FileSchema.FileCreateddate = null != reader[Constants.OUT_FILE_CREATED_DATE] ? Convert.ToDateTime(reader[Constants.OUT_FILE_CREATED_DATE].ToString().Trim()) : DateTime.Today;
            FileSchema.LastProcessingDate = null != reader[Constants.OUT_LAST_PROCESSING_DATE] ? Convert.ToDateTime(reader[Constants.OUT_LAST_PROCESSING_DATE].ToString().Trim()) : DateTime.Today;
            FileSchema.Filestatus = null != reader[Constants.OUT_FILE_STATUS] ? Convert.ToInt32(reader[Constants.OUT_FILE_STATUS].ToString().Trim()) : 0;
            FileSchema.Source = null != reader[Constants.OUT_SOURCE] ? reader[Constants.OUT_SOURCE].ToString().Trim() : string.Empty;
            FileSchema.Destination = null != reader[Constants.OUT_DESTINATION] ? reader[Constants.OUT_DESTINATION].ToString().Trim() : string.Empty;
            FileSchema.BackupPath = null != reader[Constants.OUT_BACKUP_PATH] ? reader[Constants.OUT_BACKUP_PATH].ToString().Trim() : string.Empty;
            FileSchema.NoofRecords = null != reader[Constants.OUT_NO_OF_RECORDS] ? reader[Constants.OUT_NO_OF_RECORDS].ToString().Trim() : string.Empty;
            FileSchema.SuccessfullProcessRecord = null != reader[Constants.OUT_SUCCESSFULL_PROCESS_RECORD] ? reader[Constants.OUT_SUCCESSFULL_PROCESS_RECORD].ToString().Trim() : string.Empty;
            FileSchema.UnsuccessfullRecord = null != reader[Constants.OUT_UNSUCCESSFULL__RECORDS] ? reader[Constants.OUT_UNSUCCESSFULL__RECORDS].ToString().Trim() : string.Empty;
            FileSchema.Remarks = null != reader[Constants.OUT_REMARKS] ? reader[Constants.OUT_REMARKS].ToString().Trim() : string.Empty;

            return FileSchema;
        }
    }
}

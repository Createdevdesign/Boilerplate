using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
    
    internal class TabVerifyAcceptSelectFactory : ISelectionFactory<TabVerifyAccept>
    {
        public IDbCommand ConstructSelectCommand(TabVerifyAccept idObject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;           
            sqlCommand.Parameters.Add(Constants.PS_VENDOR_CODE, SqlDbType.VarChar, 10).Value = idObject.VendorCode;

            sqlCommand.Parameters.Add(Constants.PN_INFO, SqlDbType.Int, 4).Value = idObject.Info;
            sqlCommand.Parameters.Add(Constants.PN_BANK, SqlDbType.Int, 4).Value = idObject.Bank;
            sqlCommand.Parameters.Add(Constants.PN_FINANCIAL, SqlDbType.Int, 4).Value = idObject.Financial;
            sqlCommand.Parameters.Add(Constants.PN_CERTIFICATES, SqlDbType.Int, 4).Value = idObject.Certificates;
            sqlCommand.Parameters.Add(Constants.PN_REFERENCE, SqlDbType.Int, 4).Value = idObject.Reference;
            sqlCommand.Parameters.Add(Constants.PN_ADDITIONAL, SqlDbType.Int, 4).Value = idObject.Additional;
            sqlCommand.Parameters.Add(Constants.PN_NDA, SqlDbType.Int, 4).Value = idObject.NDA;
            //sqlCommand.Parameters.Add(Constants.PN_TCOC, SqlDbType.Int, 4).Value = idObject.TCOC;
            sqlCommand.Parameters.Add(Constants.PN_DOCUMENTS, SqlDbType.Int, 4).Value = idObject.Documents;
            sqlCommand.Parameters.Add(Constants.PN_TTLUSE, SqlDbType.Int, 4).Value = idObject.TTLUse;


            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_TAB_VERIFY_ACCEPT;
            return sqlCommand;
        }
    }
}

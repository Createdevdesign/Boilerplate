using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace BoilerSupplier.Repository
{
  
    internal class InvoiceSelectFactory : ISelectionFactory<Invoice>
    {
        public IDbCommand ConstructSelectCommand(Invoice idObject)
        {


            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Add(Constants.PS_MODE, SqlDbType.VarChar, 1).Value = idObject.MODE;

            sqlCommand.Parameters.Add(Constants.PS_VENDOR_CODE, SqlDbType.VarChar, 20).Value = idObject.VendorCode;
            sqlCommand.Parameters.Add(Constants.PS_COMPANY, SqlDbType.VarChar, 30).Value = idObject.Company;
            sqlCommand.Parameters.Add(Constants.PS_INVOICE_NUMBER, SqlDbType.VarChar, 30).Value = idObject.InvoiceNumber;
            sqlCommand.Parameters.Add(Constants.PS_INVOICE_ACCOUNT, SqlDbType.VarChar, 20).Value = idObject.InvoiceAccount;
            sqlCommand.Parameters.Add(Constants.PS_VENDOR_NAME, SqlDbType.VarChar, 30).Value = idObject.VendorName;

            sqlCommand.Parameters.Add(Constants.PS_VENDOR_ACCOUNT, SqlDbType.VarChar, 30).Value = idObject.VendorAccount;
            sqlCommand.Parameters.Add(Constants.PS_PURCHASE_ORDER_NUMBER, SqlDbType.VarChar, 20).Value = idObject.PurchaseOrderNumber;
            sqlCommand.Parameters.Add(Constants.PS_POSTING_DATE, SqlDbType.VarChar, 20).Value = idObject.PostingDate;
            sqlCommand.Parameters.Add(Constants.PS_INVOICE_DATE, SqlDbType.VarChar, 20).Value = idObject.InvoiceDate;
            sqlCommand.Parameters.Add(Constants.PS_INVOICE_DESCRIPTION, SqlDbType.VarChar, 70).Value = idObject.InvoiceDescription;

            sqlCommand.Parameters.Add(Constants.PS_CURRENCY, SqlDbType.VarChar, 20).Value = idObject.Currency;
            sqlCommand.Parameters.Add(Constants.PS_LOGED, SqlDbType.VarChar, 100).Value = idObject.Loged;
            sqlCommand.Parameters.Add(Constants.PS_ERROR_MESSAGE, SqlDbType.VarChar, 50).Value = idObject.ErrorMessage;
            sqlCommand.Parameters.Add(Constants.PS_LINEREFERENCE, SqlDbType.VarChar, 50).Value = idObject.Linereference;

            sqlCommand.Parameters.Add(Constants.PN_PAGE_SIZE, SqlDbType.Int, 4).Value = idObject.PageSize;
            sqlCommand.Parameters.Add(Constants.PN_CURRENT_PAGE, SqlDbType.Int, 4).Value = idObject.CurrentPage;
            sqlCommand.Parameters.Add(Constants.PN_TOTAL_RECORDS, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(Constants.PN_ERROR_CODE, SqlDbType.Int, 4).Direction = ParameterDirection.Output;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = Constants.USP_ADD_DEL_UPDATE_INVOICE;

            return sqlCommand;
        }
    }
}

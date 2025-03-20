using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
 

    internal class InvoiceObjectFactory : IDomainObjectFactory<Invoice>
    {
        public Invoice Construct(IDataReader reader)
        {
            Invoice Invoice = new Invoice();

            Invoice.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            Invoice.Company = null != reader[Constants.OUT_COMPANY] ? reader[Constants.OUT_COMPANY].ToString().Trim() : string.Empty;
            Invoice.InvoiceNumber = null != reader[Constants.OUT_INVOICE_NUMBER] ? reader[Constants.OUT_INVOICE_NUMBER].ToString().Trim() : string.Empty;
            Invoice.InvoiceAccount = null != reader[Constants.OUT_INVOICE_ACCOUNT] ? reader[Constants.OUT_INVOICE_ACCOUNT].ToString().Trim() : string.Empty;
            Invoice.VendorName = null != reader[Constants.OUT_VENDOR_NAME] ? reader[Constants.OUT_VENDOR_NAME].ToString().Trim() : string.Empty;

            Invoice.VendorAccount = null != reader[Constants.OUT_VENDOR_ACCOUNT] ? reader[Constants.OUT_VENDOR_ACCOUNT].ToString().Trim() : string.Empty;
            Invoice.PurchaseOrderNumber = null != reader[Constants.OUT_PURCHASE_ORDER_NUMBER] ? reader[Constants.OUT_PURCHASE_ORDER_NUMBER].ToString().Trim() : string.Empty;
            Invoice.PostingDate = null != reader[Constants.OUT_POSTING_DATE] ? reader[Constants.OUT_POSTING_DATE].ToString().Trim() : string.Empty;
            Invoice.InvoiceDate = null != reader[Constants.OUT_INVOICE_DATE] ? reader[Constants.OUT_INVOICE_DATE].ToString().Trim() : string.Empty;
            Invoice.InvoiceDescription = null != reader[Constants.OUT_INVOICE_DESCRIPTION] ? reader[Constants.OUT_INVOICE_DESCRIPTION].ToString().Trim() : string.Empty;

            Invoice.Currency = null != reader[Constants.OUT_CURRENCY] ? reader[Constants.OUT_CURRENCY].ToString().Trim() : string.Empty;
            Invoice.Loged = null != reader[Constants.OUT_LOGED] ? reader[Constants.OUT_LOGED].ToString().Trim() : string.Empty;
            Invoice.ErrorMessage = null != reader[Constants.OUT_ERROR_MESSAGE] ? reader[Constants.OUT_ERROR_MESSAGE].ToString().Trim() : string.Empty;
            Invoice.Linereference = null != reader[Constants.OUT_LINEREFERENCE] ? reader[Constants.OUT_LINEREFERENCE].ToString().Trim() : string.Empty;


            return Invoice;
        }
    }
}

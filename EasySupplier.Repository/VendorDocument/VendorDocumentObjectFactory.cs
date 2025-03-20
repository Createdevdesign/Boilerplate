using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;


namespace BoilerSupplier.Repository
{
 

    internal class VendorDocumentObjectFactory : IDomainObjectFactory<VendorDocument>
    {
        public VendorDocument Construct(IDataReader reader)
        {
            VendorDocument VendorDocument = new VendorDocument();

            VendorDocument.Document_Type = null != reader[Constants.OUT_DOCUMENT_TYPE] ? reader[Constants.OUT_DOCUMENT_TYPE].ToString().Trim() : string.Empty;
            VendorDocument.Document_Name = null != reader[Constants.OUT_DOCUMENT_NAME] ? reader[Constants.OUT_DOCUMENT_NAME].ToString().Trim() : string.Empty;
            VendorDocument.Expiry_Date = null != reader[Constants.OUT_EXPIRY_DATE] ? Convert.ToDateTime(reader[Constants.OUT_EXPIRY_DATE].ToString().Trim()) : DateTime.Today;
            VendorDocument.Document_Path = null != reader[Constants.OUT_DOCUMENT_PATH] ? reader[Constants.OUT_DOCUMENT_PATH].ToString().Trim() : string.Empty;

            return VendorDocument;
        }
    }
}

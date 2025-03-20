using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    

    internal class DocumentObjectFactory : IDomainObjectFactory<Document>
    {
        public Document Construct(IDataReader reader)
        {
            Document Document = new Document();

            //Document.entitytype = null != reader[Constants.OUT_ENTITY_TYPE] ? Convert.ToDecimal(reader[Constants.OUT_ENTITY_TYPE].ToString().Trim()) : 0;
            //Document.DocumentName = null != reader[Constants.OUT_DOCUMENT_NAME] ? reader[Constants.OUT_DOCUMENT_NAME].ToString().Trim() : string.Empty;
            //Document.Org_ID = null != reader[Constants.OUT_ORG_ID] ? Convert.ToDecimal(reader[Constants.OUT_ORG_ID].ToString().Trim()) : 0;

            Document.countryID = null != reader[Constants.OUT_COUNTRY_ID] ? Convert.ToInt32(reader[Constants.OUT_COUNTRY_ID].ToString().Trim()) : 0;
            Document.Document_Name = null != reader[Constants.OUT_DOCUMENT_NAME] ? reader[Constants.OUT_DOCUMENT_NAME].ToString().Trim() : string.Empty;
            Document.Mandatory = DBNull.Value != reader[Constants.OUT_MANDATORY] ? Convert.ToBoolean(reader[Constants.OUT_MANDATORY].ToString().Trim()) : false;


            return Document;
        }
    }
}

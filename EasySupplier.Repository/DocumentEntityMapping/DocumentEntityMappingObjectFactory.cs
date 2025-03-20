using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    internal class DocumentEntityMappingObjectFactory : IDomainObjectFactory<DocumentEntityMapping>
    {
        public DocumentEntityMapping Construct(IDataReader reader)
        {
            DocumentEntityMapping DocumentEntityMapping = new DocumentEntityMapping();

            DocumentEntityMapping.entitycode = null != reader[Constants.OUT_ENTITY_CODE] ? reader[Constants.OUT_ENTITY_CODE].ToString().Trim() : string.Empty;
            DocumentEntityMapping.Document = null != reader[Constants.OUT_DOCUMENT] ? Convert.ToDecimal(reader[Constants.OUT_DOCUMENT].ToString().Trim()) : 0;
            DocumentEntityMapping.Mandatory = DBNull.Value != reader[Constants.OUT_MANDATORY_YN] ? Convert.ToBoolean(reader[Constants.OUT_MANDATORY_YN].ToString().Trim()) : false;
            DocumentEntityMapping.Updatedby = null != reader[Constants.OUT_UPDATED_BY] ? reader[Constants.OUT_UPDATED_BY].ToString().Trim() : string.Empty;
            DocumentEntityMapping.Updateddate = null != reader[Constants.OUT_UPDATED_DATE] ? Convert.ToDateTime(reader[Constants.OUT_UPDATED_DATE].ToString().Trim()) : DateTime.Today;
         
            return DocumentEntityMapping;
        }
    }
}

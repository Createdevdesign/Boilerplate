using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    
    internal class DocumentEntityMappingService : IDocumentEntityMappingService
    {
        private IDataManger DocumentEntityMappingDataManger;

        public DocumentEntityMappingService(DataManger dataManger)
        {
            this.DocumentEntityMappingDataManger = dataManger;
        }

        public IList<DocumentEntityMapping> GetAllDocumentEntityMappingData(DocumentEntityMapping input)
        {
            var DocumentEntityMappingData = DocumentEntityMappingDataManger.GetAllDocumentEntityMappingData(input);
            return DocumentEntityMappingData;
        }
    }
}

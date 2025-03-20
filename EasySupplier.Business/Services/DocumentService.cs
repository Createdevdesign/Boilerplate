using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   

    internal class DocumentService : IDocumentService
    {
        private IDataManger DocumentDataManger;

        public DocumentService(DataManger dataManger)
        {
            this.DocumentDataManger = dataManger;
        }

        public IList<Document> GetAllDocumentData(Document input)
        {
            var DocumentData = DocumentDataManger.GetAllDocumentData(input);
            return DocumentData;
        }
    }
}

using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
   

    internal class DocumentRepository : Repository<Document>
    {
        public List<Document> GetAllDocumentData(Document input)
        {
            ISelectionFactory<Document> selectionFactory = new DocumentSelectFactory();
            IDomainObjectFactory<Document> objectFactory = new DocumentObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

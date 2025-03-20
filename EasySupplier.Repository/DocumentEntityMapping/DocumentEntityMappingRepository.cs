using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{
   
    internal class DocumentEntityMappingRepository : Repository<DocumentEntityMapping>
    {
        public List<DocumentEntityMapping> GetAllDocumentEntityMappingData(DocumentEntityMapping input)
        {
            ISelectionFactory<DocumentEntityMapping> selectionFactory = new DocumentEntityMappingSelectFactory();
            IDomainObjectFactory<DocumentEntityMapping> objectFactory = new DocumentEntityMappingObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

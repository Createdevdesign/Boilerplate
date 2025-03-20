using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{


    internal class FileSchemaRepository : Repository<FileSchema>
    {
        public List<FileSchema> GetAllFileSchemaData(FileSchema input)
        {
            ISelectionFactory<FileSchema> selectionFactory = new FileSchemaSelectFactory();
            IDomainObjectFactory<FileSchema> objectFactory = new FileSchemaObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

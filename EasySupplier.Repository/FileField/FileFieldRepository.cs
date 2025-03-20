using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
  
    internal class FileFieldRepository : Repository<FileField>
    {
        public List<FileField> GetAllFileFieldData(FileField input)
        {
            ISelectionFactory<FileField> selectionFactory = new FileFieldSelectFactory();
            IDomainObjectFactory<FileField> objectFactory = new FileFieldObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

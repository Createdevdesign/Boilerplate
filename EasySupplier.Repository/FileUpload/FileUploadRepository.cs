using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    
    internal class FileUploadRepository : Repository<FileUpload>
    {
        public List<FileUpload> GetAllFileUploadData(FileUpload input)
        {
            ISelectionFactory<FileUpload> selectionFactory = new FileUploadSelectFactory();
            IDomainObjectFactory<FileUpload> objectFactory = new FileUploadObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    
    internal class FileMasterRepository : Repository<FileMaster>
    {
        public List<FileMaster> GetAllFileMasterData(FileMaster input)
        {
            ISelectionFactory<FileMaster> selectionFactory = new FileMasterSelectFactory();
            IDomainObjectFactory<FileMaster> objectFactory = new FileMasterObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
  
    internal class vehiclemappingRepository : Repository<vehiclemapping>
    {
        public List<vehiclemapping> GetAllvehiclemappingData(vehiclemapping input)
        {
            ISelectionFactory<vehiclemapping> selectionFactory = new vehiclemappingSelectFactory();
            IDomainObjectFactory<vehiclemapping> objectFactory = new vehiclemappingObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

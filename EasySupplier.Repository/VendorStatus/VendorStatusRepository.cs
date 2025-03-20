using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
  

    internal class VendorStatusRepository : Repository<VendorStatus>
    {
        public List<VendorStatus> GetAllVendorStatusData(VendorStatus input)
        {
            ISelectionFactory<VendorStatus> selectionFactory = new VendorStatusSelectFactory();
            IDomainObjectFactory<VendorStatus> objectFactory = new VendorStatusObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

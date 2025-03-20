using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
   
    internal class VendorRepository : Repository<Vendor>
    {
        public List<Vendor> GetAllVendorData(Vendor input)
        {
            ISelectionFactory<Vendor> selectionFactory = new VendorSelectFactory();
            IDomainObjectFactory<Vendor> objectFactory = new VendorObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

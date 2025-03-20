using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class VendorClassificationGSTRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllVendorClassificationGSTData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new VendorClassificationGSTSelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new VendorClassificationGSTObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

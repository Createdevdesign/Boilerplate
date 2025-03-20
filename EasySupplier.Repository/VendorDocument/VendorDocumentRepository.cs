using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{

    internal class VendorDocumentRepository : Repository<VendorDocument>
    {
        public List<VendorDocument> GetAllVendorDocumentData(VendorDocument input)
        {
            ISelectionFactory<VendorDocument> selectionFactory = new VendorDocumentSelectFactory();
            IDomainObjectFactory<VendorDocument> objectFactory = new VendorDocumentObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

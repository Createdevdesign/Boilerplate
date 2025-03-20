using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{


    internal class VendorSAPRepository : Repository<VendorSAP>
    {
        public List<VendorSAP> GetAllVendorSAPData(VendorSAP input)
        {
            ISelectionFactory<VendorSAP> selectionFactory = new VendorSAPSelectFactory();
            IDomainObjectFactory<VendorSAP> objectFactory = new VendorSAPObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }

        public VendorSAP GetVendorSAPData(VendorSAP input)
        {
            ISelectionFactory<VendorSAP> selectionFactory = new VendorSAPSelectFactory();
            IDomainObjectFactory<VendorSAP> objectFactory = new VendorSAPObjectFactory();
            return base.GetValue(selectionFactory, objectFactory, input);
        }
    }
}

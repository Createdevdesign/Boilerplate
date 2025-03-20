using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{
    internal class SupplierDetailsRepository : Repository<Vendor>
    {
        public List<Vendor> GetAllSupplierDetailsData(Vendor input)
        {
            ISelectionFactory<Vendor> selectionFactory = new SupplierDetailsSelectFactory();
            IDomainObjectFactory<Vendor> objectFactory = new SupplierDetailsObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

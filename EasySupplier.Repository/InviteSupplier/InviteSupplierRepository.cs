using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    

    internal class InviteSupplierRepository : Repository<InviteSupplier>
    {
        public List<InviteSupplier> GetAllInviteSupplierData(InviteSupplier input)
        {
            ISelectionFactory<InviteSupplier> selectionFactory = new InviteSupplierSelectFactory();
            IDomainObjectFactory<InviteSupplier> objectFactory = new InviteSupplierObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

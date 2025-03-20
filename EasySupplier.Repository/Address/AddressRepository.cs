using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{
   
    internal class AddressRepository : Repository<Address>
    {
        public List<Address> GetAllAddressData(Address input)
        {
            ISelectionFactory<Address> selectionFactory = new AddressSelectFactory();
            IDomainObjectFactory<Address> objectFactory = new AddressObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

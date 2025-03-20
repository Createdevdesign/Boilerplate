using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    
    internal class SubmerchantRepository : Repository<Submerchant>
    {
        public List<Submerchant> GetAllSubmerchantData(Submerchant input)
        {
            ISelectionFactory<Submerchant> selectionFactory = new SubmerchantSelectFactory();
            IDomainObjectFactory<Submerchant> objectFactory = new SubmerchantObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

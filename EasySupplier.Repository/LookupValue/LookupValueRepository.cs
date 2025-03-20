using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{

    internal class LookupValueRepository : Repository<LookupValue>
    {
        public List<LookupValue> GetAllLookupValueData(LookupValue input)
        {
            ISelectionFactory<LookupValue> selectionFactory = new LookupValueSelectFactory();
            IDomainObjectFactory<LookupValue> objectFactory = new LookupValueObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

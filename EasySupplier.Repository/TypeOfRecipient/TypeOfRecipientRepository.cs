using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class TypeOfRecipientRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllTypeOfRecipientData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new TypeOfRecipientSelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new TypeOfRecipientObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

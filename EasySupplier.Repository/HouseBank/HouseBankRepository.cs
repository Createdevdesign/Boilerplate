using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class HouseBankRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllHouseBankData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new HouseBankSelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new HouseBankObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

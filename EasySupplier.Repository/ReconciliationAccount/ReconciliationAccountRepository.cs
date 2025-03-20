using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class ReconciliationAccountRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllReconciliationAccountData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new ReconciliationAccountSelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new ReconciliationAccountObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

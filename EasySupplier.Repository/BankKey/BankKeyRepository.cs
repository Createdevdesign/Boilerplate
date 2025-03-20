using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class BankKeyRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllBankKeyData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new BankKeySelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new BankKeyObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

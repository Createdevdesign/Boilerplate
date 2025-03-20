using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class PaymentBlockRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllPaymentBlockData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new PaymentBlockSelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new PaymentBlockObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

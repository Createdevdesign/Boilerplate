using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class PaymentTermRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllPaymentTermData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new PaymentTermSelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new PaymentTermObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

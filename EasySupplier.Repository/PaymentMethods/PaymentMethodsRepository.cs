using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class PaymentMethodsRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllPaymentMethodsData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new PaymentMethodsSelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new PaymentMethodsObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

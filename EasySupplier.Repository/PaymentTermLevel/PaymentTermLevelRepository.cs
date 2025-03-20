using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class PaymentTermLevelRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllPaymentTermLevelData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new PaymentTermLevelSelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new PaymentTermLevelObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

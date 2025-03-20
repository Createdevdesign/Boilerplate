using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
   
    internal class PurchaseOrderRepository : Repository<PurchaseOrder>
    {
        public List<PurchaseOrder> GetAllPurchaseOrderData(PurchaseOrder input)
        {
            ISelectionFactory<PurchaseOrder> selectionFactory = new PurchaseOrderSelectFactory();
            IDomainObjectFactory<PurchaseOrder> objectFactory = new PurchaseOrderObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

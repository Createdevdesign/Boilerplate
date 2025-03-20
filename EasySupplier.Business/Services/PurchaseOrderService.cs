using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    
    internal class PurchaseOrderService : IPurchaseOrderService
    {
        private IDataManger PurchaseOrderDataManger;

        public PurchaseOrderService(DataManger dataManger)
        {
            this.PurchaseOrderDataManger = dataManger;
        }

        public IList<PurchaseOrder> GetAllPurchaseOrderData(PurchaseOrder input)
        {
            var PurchaseOrderData = PurchaseOrderDataManger.GetAllPurchaseOrderData(input);
            return PurchaseOrderData;
        }
    }
}

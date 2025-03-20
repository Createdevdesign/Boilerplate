using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
   

    public interface IPurchaseOrderService
    {
        /// <summary>
        /// Get all PurchaseOrder data
        /// </summary>
        /// <param name="input">PurchaseOrder Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<PurchaseOrder> GetAllPurchaseOrderData(PurchaseOrder input);
    }
}

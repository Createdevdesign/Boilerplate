using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    
    public interface IInvoiceService
    {
        /// <summary>
        /// Get all Invoice  data
        /// </summary>
        /// <param name="input">Invoice Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<Invoice> GetAllInvoiceData(Invoice input);
    }
}

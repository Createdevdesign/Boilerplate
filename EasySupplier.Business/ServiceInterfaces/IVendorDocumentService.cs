using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
   
    public interface IVendorDocumentService
    {
        /// <summary>
        /// Get all Vendor Document table data
        /// </summary>
        /// <param name="input">Vendor Document Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<VendorDocument> GetAllVendorDocumentData(VendorDocument input);
    }
}

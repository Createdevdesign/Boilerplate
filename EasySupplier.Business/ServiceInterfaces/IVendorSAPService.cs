using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    
    public interface IVendorSAPService
    {
        /// <summary>
        /// Get all Vendor SAP  data
        /// </summary>
        /// <param name="input">Vendor SAP Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<VendorSAP> GetAllVendorSAPData(VendorSAP input);

        VendorSAP GetVendorSAPData(VendorSAP input);
    }
}

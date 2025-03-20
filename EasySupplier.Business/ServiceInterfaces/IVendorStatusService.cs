using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;



namespace BoilerSupplier.Business
{
  

    public interface IVendorStatusService
    {
        /// <summary>
        /// Get all VendorStatus data
        /// </summary>
        /// <param name="input">VendorStatus Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<VendorStatus> GetAllVendorStatusData(VendorStatus input);
    }
}

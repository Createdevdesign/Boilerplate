using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    

    public interface IVendorService
    {
        /// <summary>
        /// Get all Vendor Master data
        /// </summary>
        /// <param name="input">Vendor Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<Vendor> GetAllVendorData(Vendor input);
    }
}

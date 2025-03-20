using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    

    public interface ISupplierDetailsService
    {
        /// <summary>
        /// Get all SupplierDetails  data
        /// </summary>
        /// <param name="input">SupplierDetails Domain Object</param>
        /// <returns>Collection of SupplierDetails Domain Object</returns>
        IList<Vendor> GetAllSupplierDetailsData(Vendor input);
    }
}

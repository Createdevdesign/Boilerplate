using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface IAddressService
    {
        /// <summary>
        /// Get all Address Master data
        /// </summary>
        /// <param name="input">Address Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<Address> GetAllAddressData(Address input);
    }
}

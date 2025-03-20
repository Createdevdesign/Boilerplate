using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;


namespace BoilerSupplier.Business
{
  
    public interface ISubmerchantService
    {
        /// <summary>
        /// Get all Submerchant Master data
        /// </summary>
        /// <param name="input">Submerchant Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<Submerchant> GetAllSubmerchantData(Submerchant input);
    }
}

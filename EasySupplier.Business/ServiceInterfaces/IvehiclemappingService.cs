using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
  
    public interface IvehiclemappingService
    {
        /// <summary>
        /// Get all vehiclemapping Master data
        /// </summary>
        /// <param name="input">vehiclemapping Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<vehiclemapping> GetAllvehiclemappingData(vehiclemapping input);
    }
}

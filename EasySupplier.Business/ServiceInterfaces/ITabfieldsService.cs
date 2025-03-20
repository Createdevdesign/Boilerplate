using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    
     public interface ITabfieldsService
    {
        /// <summary>
        /// Get all Tabfields Master data
        /// </summary>
        /// <param name="input">Tabfields Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<Tabfields> GetAllTabfieldsData(Tabfields input);
    }
}

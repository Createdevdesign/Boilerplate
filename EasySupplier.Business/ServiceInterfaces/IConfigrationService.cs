using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface IConfigrationService
    {
        /// <summary>
        /// Get all Configration Master data
        /// </summary>
        /// <param name="input">Configration Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<ConfigrationMaster> GetAllConfigrationData(ConfigrationMaster input);
    }
}

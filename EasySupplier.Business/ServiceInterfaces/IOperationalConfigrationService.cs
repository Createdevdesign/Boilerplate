using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface IOperationalConfigrationService
    {
        /// <summary>
        /// Get all Operational Configration Master data
        /// </summary>
        /// <param name="input">Operational Configration Master Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<OperationalConfigrationMaster> GetAllOperationalConfigrationData(OperationalConfigrationMaster input);
    }
}

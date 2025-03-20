using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface IModuleService
    {
        /// <summary>
        /// Get all Module Master data
        /// </summary>
        /// <param name="input">Module Master Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<ModuleMaster> GetAllModuleData(ModuleMaster input);
    }
}

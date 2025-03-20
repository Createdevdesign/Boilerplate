using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface IModuleAssigmentService
    {
        /// <summary>
        /// Get all Module_Assigment data
        /// </summary>
        /// <param name="input">Module_Assigment Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<Module_Assigment> GetAllModuleAssigmentData(Module_Assigment input);
    }
}

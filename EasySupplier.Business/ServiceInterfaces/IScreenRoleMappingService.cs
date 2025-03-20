using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface IScreenRoleMappingService
    {
        /// <summary>
        /// Get all ScreenRoleMapping data
        /// </summary>
        /// <param name="input">ScreenRoleMapping Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<ScreenRoleMapping> GetAllScreenRoleMappingData(ScreenRoleMapping input);
    }
}

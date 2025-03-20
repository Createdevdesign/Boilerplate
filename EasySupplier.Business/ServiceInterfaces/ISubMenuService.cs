using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface ISubMenuService
    {
        /// <summary>
        /// Get all SubMenu data
        /// </summary>
        /// <param name="input">SubMenu Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<SubMenu> GetAllSubMenuData(SubMenu input);
    }
}

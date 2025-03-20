using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface IMainMenuService
    {
        /// <summary>
        /// Get all MainMenu data
        /// </summary>
        /// <param name="input">MainMenu Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<MainMenu> GetAllMainMenuData(MainMenu input);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    

    public interface IRegisterListService
    {
        /// <summary>
        /// Get all RegisterList  data
        /// </summary>
        /// <param name="input">RegisterList Domain Object</param>
        /// <returns>Collection of RegisterList Domain Object</returns>
        IList<RegisterList> GetAllRegisterListData(RegisterList input);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
   

    public interface IWIPApplicationListService
    {
        /// <summary>
        /// Get all WIPApplicationList  data
        /// </summary>
        /// <param name="input">WIPApplicationList Domain Object</param>
        /// <returns>Collection of WIPApplicationList Domain Object</returns>
        IList<WIPApplicationList> GetAllWIPApplicationListData(WIPApplicationList input);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface ILookupValueService
    {
        /// <summary>
        /// Get all LookupValue data
        /// </summary>
        /// <param name="input">LookupValue Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<LookupValue> GetAllLookupValueData(LookupValue input);
       
    }
}

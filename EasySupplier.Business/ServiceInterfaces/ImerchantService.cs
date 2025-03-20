using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    
    public interface ImerchantService
    {
        /// <summary>
        /// Get all merchant Master data
        /// </summary>
        /// <param name="input">merchant Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<merchant> GetAllmerchantData(merchant input);
    }
}

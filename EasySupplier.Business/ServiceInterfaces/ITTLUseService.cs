using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    

    public interface ITTLUseService
    {
        /// <summary>
        /// Get all TTLUse data
        /// </summary>
        /// <param name="input">TTLUse Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<TTLUse> GetAllTTLUseData(TTLUse input);
    }
}

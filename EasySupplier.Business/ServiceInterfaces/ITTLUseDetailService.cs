using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;


namespace BoilerSupplier.Business
{
    

    public interface ITTLUseDetailService
    {
        /// <summary>
        /// Get all TTLUseDetail  data
        /// </summary>
        /// <param name="input">TTLUseDetail Domain Object</param>
        /// <returns>Collection of TTLUseDetail Domain Object</returns>
        IList<TTLUse> GetAllTTLUseDetailData(TTLUse input);
    }
}

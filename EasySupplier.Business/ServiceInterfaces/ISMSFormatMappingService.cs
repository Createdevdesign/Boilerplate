using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    
    public interface ISMSFormatMappingService
    {
        /// <summary>
        /// Get all SMSFormatMapping Master data
        /// </summary>
        /// <param name="input">SMSFormatMapping Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<SMSFormatMapping> GetAllSMSFormatMappingData(SMSFormatMapping input);
    }
}

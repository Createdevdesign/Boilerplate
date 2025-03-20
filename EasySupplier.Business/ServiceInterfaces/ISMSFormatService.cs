using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface ISMSFormatService
    {
        /// <summary>
        /// Get all SMSFormat data
        /// </summary>
        /// <param name="input">SMSFormat Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<SMSFormat> GetAllSMSFormatData(SMSFormat input);
    }
}

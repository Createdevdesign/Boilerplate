using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    
    public interface IEmailFormatMappingService
    {
        /// <summary>
        /// Get all EmailFormatMapping Master data
        /// </summary>
        /// <param name="input">EmailFormatMapping Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<EmailFormatMapping> GetAllEmailFormatMappingData(EmailFormatMapping input);
    }
}

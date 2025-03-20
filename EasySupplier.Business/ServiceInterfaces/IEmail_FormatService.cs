using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    
    public interface IEmail_FormatService
    {
        /// <summary>
        /// Get all Email_Format Master data
        /// </summary>
        /// <param name="input">Email_Format Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<Email_Format> GetAllEmail_FormatData(Email_Format input);
    }
}

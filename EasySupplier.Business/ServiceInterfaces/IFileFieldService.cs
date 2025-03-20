using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    
    public interface IFileFieldService
    {
        /// <summary>
        /// Get all FileField Master data
        /// </summary>
        /// <param name="input">FileField Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<FileField> GetAllFileFieldData(FileField input);
    }
}

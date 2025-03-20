using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface IFileSchemaService
    {
        /// <summary>
        /// Get all FileSchema data
        /// </summary>
        /// <param name="input">FileSchema Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<FileSchema> GetAllFileSchemaData(FileSchema input);
    }
}

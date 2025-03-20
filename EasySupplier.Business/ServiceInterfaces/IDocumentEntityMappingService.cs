using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
  
    public interface IDocumentEntityMappingService
    {
        /// <summary>
        /// Get all DocumentEntityMapping Master data
        /// </summary>
        /// <param name="input">DocumentEntityMapping Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<DocumentEntityMapping> GetAllDocumentEntityMappingData(DocumentEntityMapping input);
    }
}

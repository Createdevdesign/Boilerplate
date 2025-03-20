using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
   

    public interface IDocumentService
    {
        /// <summary>
        /// Get all Document Master data
        /// </summary>
        /// <param name="input">Document Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<Document> GetAllDocumentData(Document input);
    }
}

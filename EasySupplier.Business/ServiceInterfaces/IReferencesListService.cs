using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
   
    public interface IReferencesListService
    {
        /// <summary>
        /// Get all ReferencesList  data
        /// </summary>
        /// <param name="input">ReferencesList Domain Object</param>
        /// <returns>Collection of ReferencesList Domain Object</returns>
        IList<Vendor> GetAllReferencesListData(Vendor input);
    }
}

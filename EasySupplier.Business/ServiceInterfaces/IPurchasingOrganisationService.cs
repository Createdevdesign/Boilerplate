using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    
    public interface IPurchasingOrganisationService
    {
        /// <summary>
        /// Get all PurchasingOrganisation data
        /// </summary>
        /// <param name="input">PurchasingOrganisation Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<SAPMaster> GetAllPurchasingOrganisationData(SAPMaster input);

    }
}

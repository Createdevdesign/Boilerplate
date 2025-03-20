using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   

    internal class PurchasingOrganisationService : IPurchasingOrganisationService
    {
        private IDataManger PurchasingOrganisationDataManger;

        public PurchasingOrganisationService(DataManger dataManger)
        {
            this.PurchasingOrganisationDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllPurchasingOrganisationData(SAPMaster input)
        {
            var PurchasingOrganisationData = PurchasingOrganisationDataManger.GetAllPurchasingOrganisationData(input);
            return PurchasingOrganisationData;
        }
    }
}

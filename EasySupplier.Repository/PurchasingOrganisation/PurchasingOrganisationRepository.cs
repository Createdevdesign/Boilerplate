using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    

    internal class PurchasingOrganisationRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllPurchasingOrganisationData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new PurchasingOrganisationSelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new PurchasingOrganisationObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

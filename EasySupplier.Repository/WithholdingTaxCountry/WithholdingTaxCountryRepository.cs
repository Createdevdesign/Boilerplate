using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class WithholdingTaxCountryRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllWithholdingTaxCountryData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new WithholdingTaxCountrySelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new WithholdingTaxCountryObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

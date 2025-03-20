using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class WithholdingTaxCodeExemptionRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllWithholdingTaxCodeExemptionData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new WithholdingTaxCodeExemptionSelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new WithholdingTaxCodeExemptionObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

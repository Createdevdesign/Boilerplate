using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class WithholdingTaxTypeExemptionRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllWithholdingTaxTypeExemptionData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new WithholdingTaxTypeExemptionSelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new WithholdingTaxTypeExemptionObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

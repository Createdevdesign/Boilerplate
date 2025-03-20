using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class WithholdingTaxTypeRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllWithholdingTaxTypeData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new WithholdingTaxTypeSelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new WithholdingTaxTypeObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

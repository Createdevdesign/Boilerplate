using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class WithholdingTaxCodeRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllWithholdingTaxCodeData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new WithholdingTaxCodeSelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new WithholdingTaxCodeObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{
    internal class SectionCodeRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllSectionCodeData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new SectionCodeSelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new SectionCodeObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

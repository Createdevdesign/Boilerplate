using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class SchemaGroupVendorRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllSchemaGroupVendorData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new SchemaGroupVendorSelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new SchemaGroupVendorObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

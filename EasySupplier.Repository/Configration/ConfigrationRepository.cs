using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class ConfigrationRepository : Repository<ConfigrationMaster>
    {
        public List<ConfigrationMaster> GetAllConfigrationData(ConfigrationMaster input)
        {
            ISelectionFactory<ConfigrationMaster> selectionFactory = new ConfigrationSelectFactory();
            IDomainObjectFactory<ConfigrationMaster> objectFactory = new ConfigrationObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

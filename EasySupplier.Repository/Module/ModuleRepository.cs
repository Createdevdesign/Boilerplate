using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class ModuleRepository : Repository<ModuleMaster>
    {
        public List<ModuleMaster> GetAllModuleData(ModuleMaster input)
        {
            ISelectionFactory<ModuleMaster> selectionFactory = new ModuleSelectFactory();
            IDomainObjectFactory<ModuleMaster> objectFactory = new ModuleObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

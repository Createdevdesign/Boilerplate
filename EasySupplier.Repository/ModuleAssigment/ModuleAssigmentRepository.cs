using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{
    internal class ModuleAssigmentRepository : Repository<Module_Assigment>
    {
        public List<Module_Assigment> GetAllModuleAssigmentData(Module_Assigment input)
        {
            ISelectionFactory<Module_Assigment> selectionFactory = new ModuleAssigmentSelectFactory();
            IDomainObjectFactory<Module_Assigment> objectFactory = new ModuleAssigmentObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

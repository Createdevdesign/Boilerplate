using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class ScreenRoleMappingRepository : Repository<ScreenRoleMapping>
    {
        public List<ScreenRoleMapping> GetAllScreenRoleMappingData(ScreenRoleMapping input)
        {
            ISelectionFactory<ScreenRoleMapping> selectionFactory = new ScreenRoleMappingSelectFactory();
            IDomainObjectFactory<ScreenRoleMapping> objectFactory = new ScreenRoleMappingObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

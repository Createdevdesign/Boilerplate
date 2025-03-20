using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Repository
{
    internal class SubMenuRepository : Repository<SubMenu>
    {
        public List<SubMenu> GetAllSubMenuData(SubMenu input)
        {
            ISelectionFactory<SubMenu> selectionFactory = new SubMenuSelectFactory();
            IDomainObjectFactory<SubMenu> objectFactory = new SubMenuObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

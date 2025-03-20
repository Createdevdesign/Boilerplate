using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class MainMenuRepository : Repository<MainMenu>
    {
        public List<MainMenu> GetAllMainMenuData(MainMenu input)
        {
            ISelectionFactory<MainMenu> selectionFactory = new MainMenuSelectFactory();
            IDomainObjectFactory<MainMenu> objectFactory = new MainMenuObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    

    internal class TabfieldsRepository : Repository<Tabfields>
    {
        public List<Tabfields> GetAllTabfieldsData(Tabfields input)
        {
            ISelectionFactory<Tabfields> selectionFactory = new TabfieldsSelectFactory();
            IDomainObjectFactory<Tabfields> objectFactory = new TabfieldsObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

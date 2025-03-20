using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{
  

    internal class WIPApplicationListRepository : Repository<WIPApplicationList>
    {
        public List<WIPApplicationList> GetAllWIPApplicationListData(WIPApplicationList input)
        {
            ISelectionFactory<WIPApplicationList> selectionFactory = new WIPApplicationListSelectFactory();
            IDomainObjectFactory<WIPApplicationList> objectFactory = new WIPApplicationListObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

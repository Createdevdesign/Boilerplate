using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
   
    internal class RegisterListRepository : Repository<RegisterList>
    {
        public List<RegisterList> GetAllRegisterListData(RegisterList input)
        {
            ISelectionFactory<RegisterList> selectionFactory = new RegisterListSelectFactory();
            IDomainObjectFactory<RegisterList> objectFactory = new RegisterListObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

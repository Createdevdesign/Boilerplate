using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
   
    internal class UserRepository : Repository<User>
    {
        public List<User> GetAllUserData(User input)
        {
            ISelectionFactory<User> selectionFactory = new UserSelectFactory();
            IDomainObjectFactory<User> objectFactory = new UserObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

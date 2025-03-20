using BoilerSupplier.DataTransferObject;
using System;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    internal class LoginRepository : Repository<User>
    {
        
        public User FindUserByIdAndPassword(User input)
        {
            ISelectionFactory<User> selectionFactory = new LoginSelectFactory();
            IDomainObjectFactory<User> objectFactory = new LoginObjectFactory();
            return base.GetValue(selectionFactory, objectFactory, input);
        }

        //26-7-2021
        public User LoginCheck(User input)
        {
            ISelectionFactory<User> selectionFactory = new LoginSelectFactory();
            IDomainObjectFactory<User> objectFactory = new LoginObjectFactory();
            return base.GetValue(selectionFactory, objectFactory, input);
        }
    }
}

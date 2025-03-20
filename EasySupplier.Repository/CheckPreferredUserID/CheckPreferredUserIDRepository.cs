using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
  

    internal class CheckPreferredUserIDRepository : Repository<Signup>
    {
        public List<Signup> CheckPreferredUserID(Signup input)
        {
            ISelectionFactory<Signup> selectionFactory = new CheckPreferredUserIDSelectFactory();
            IDomainObjectFactory<Signup> objectFactory = new CheckPreferredUserIDObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

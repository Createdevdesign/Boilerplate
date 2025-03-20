using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
  

    internal class InviteRepository : Repository<Invite>
    {
        public List<Invite> GetAllInviteData(Invite input)
        {
            ISelectionFactory<Invite> selectionFactory = new InviteSelectFactory();
            IDomainObjectFactory<Invite> objectFactory = new InviteObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

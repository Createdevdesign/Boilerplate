using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    

    internal class InviteListRepository : Repository<Invite>
    {
        public List<Invite> GetAllInviteListData(Invite input)
        {
            ISelectionFactory<Invite> selectionFactory = new InviteListSelectFactory();
            IDomainObjectFactory<Invite> objectFactory = new InviteListObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

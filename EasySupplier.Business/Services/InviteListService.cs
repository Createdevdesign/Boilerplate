using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   

    internal class InviteListService : IInviteListService
    {
        private IDataManger InviteListDataManger;

        public InviteListService(DataManger dataManger)
        {
            this.InviteListDataManger = dataManger;
        }

        public IList<Invite> GetAllInviteListData(Invite input)
        {
            var InviteListData = InviteListDataManger.GetAllInviteListData(input);
            return InviteListData;
        }
    }
}

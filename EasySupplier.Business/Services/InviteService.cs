using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
  
    internal class InviteService : IInviteService
    {
        private IDataManger InviteDataManger;

        public InviteService(DataManger dataManger)
        {
            this.InviteDataManger = dataManger;
        }

        public IList<Invite> GetAllInviteData(Invite input)
        {
            var InviteData = InviteDataManger.GetAllInviteData(input);
            return InviteData;
        }
    }
}

using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   

    internal class InviteSupplierService : IInviteSupplierService
    {
        private IDataManger InviteSupplierDataManger;

        public InviteSupplierService(DataManger dataManger)
        {
            this.InviteSupplierDataManger = dataManger;
        }

        public IList<InviteSupplier> GetAllInviteSupplierData(InviteSupplier input)
        {
            var InviteSupplierData = InviteSupplierDataManger.GetAllInviteSupplierData(input);
            return InviteSupplierData;
        }
    }
}

using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    

    internal class VendorStatusService : IVendorStatusService
    {
        private IDataManger VendorStatusDataManger;

        public VendorStatusService(DataManger dataManger)
        {
            this.VendorStatusDataManger = dataManger;
        }

        public IList<VendorStatus> GetAllVendorStatusData(VendorStatus input)
        {
            var VendorStatusData = VendorStatusDataManger.GetAllVendorStatusData(input);
            return VendorStatusData;
        }
    }
}

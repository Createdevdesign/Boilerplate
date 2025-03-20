using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{


    internal class VendorSAPService : IVendorSAPService
    {
        private IDataManger VendorSAPDataManger;

        public VendorSAPService(DataManger dataManger)
        {
            this.VendorSAPDataManger = dataManger;
        }

        public IList<VendorSAP> GetAllVendorSAPData(VendorSAP input)
        {
            var VendorSAPData = VendorSAPDataManger.GetAllVendorSAPData(input);
            return VendorSAPData;
        }

        public VendorSAP GetVendorSAPData(VendorSAP input)
        {
            return VendorSAPDataManger.GetVendorSAPData(input);
        }
    }
}

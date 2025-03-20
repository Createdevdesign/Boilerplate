using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace BoilerSupplier.Business
{
  
    internal class VendorService : IVendorService
    {
        private IDataManger VendorDataManger;

        public VendorService(DataManger dataManger)
        {
            this.VendorDataManger = dataManger;
        }

        public IList<Vendor> GetAllVendorData(Vendor input)
        {
            var VendorData = VendorDataManger.GetAllVendorData(input);
            return VendorData;
        }
    }
}

using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace BoilerSupplier.Business
{
   
    internal class VendorClassificationGSTService : IVendorClassificationGSTService
    {
        private IDataManger VendorClassificationGSTDataManger;

        public VendorClassificationGSTService(DataManger dataManger)
        {
            this.VendorClassificationGSTDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllVendorClassificationGSTData(SAPMaster input)
        {
            var VendorClassificationGSTData = VendorClassificationGSTDataManger.GetAllVendorClassificationGSTData(input);
            return VendorClassificationGSTData;
        }
    }
}

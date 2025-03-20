using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace BoilerSupplier.Business
{
  
    internal class VendorDocumentService : IVendorDocumentService
    {
        private IDataManger VendorDocumentDataManger;

        public VendorDocumentService(DataManger dataManger)
        {
            this.VendorDocumentDataManger = dataManger;
        }

        public IList<VendorDocument> GetAllVendorDocumentData(VendorDocument input)
        {
            var VendorDocumentData = VendorDocumentDataManger.GetAllVendorDocumentData(input);
            return VendorDocumentData;
        }
    }
}

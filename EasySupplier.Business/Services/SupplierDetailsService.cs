using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   

    internal class SupplierDetailsService : ISupplierDetailsService
    {
        private IDataManger SupplierDetailsDataManger;

        public SupplierDetailsService(DataManger dataManger)
        {
            this.SupplierDetailsDataManger = dataManger;
        }

        public IList<Vendor> GetAllSupplierDetailsData(Vendor input)
        {
            var SupplierDetailsData = SupplierDetailsDataManger.GetAllSupplierDetailsData(input);
            return SupplierDetailsData;
        }
    }
}

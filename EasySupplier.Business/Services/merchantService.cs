using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    
    internal class merchantService : ImerchantService
    {
        private IDataManger merchantDataManger;

        public merchantService(DataManger dataManger)
        {
            this.merchantDataManger = dataManger;
        }

        public IList<merchant> GetAllmerchantData(merchant input)
        {
            var merchantData = merchantDataManger.GetAllmerchantData(input);
            return merchantData;
        }
    }
}

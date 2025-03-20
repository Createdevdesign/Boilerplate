using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   
    internal class AddressService : IAddressService
    {
        private IDataManger AddressDataManger;

        public AddressService(DataManger dataManger)
        {
            this.AddressDataManger = dataManger;
        }

        public IList<Address> GetAllAddressData(Address input)
        {
            var AddressData = AddressDataManger.GetAllAddressData(input);
            return AddressData;
        }
    }
}

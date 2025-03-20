using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    
    internal class SubmerchantService : ISubmerchantService
    {
        private IDataManger SubmerchantDataManger;

        public SubmerchantService(DataManger dataManger)
        {
            this.SubmerchantDataManger = dataManger;
        }

        public IList<Submerchant> GetAllSubmerchantData(Submerchant input)
        {
            var SubmerchantData = SubmerchantDataManger.GetAllSubmerchantData(input);
            return SubmerchantData;
        }
    }
}

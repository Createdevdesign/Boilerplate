using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    
    internal class vehiclemappingService : IvehiclemappingService
    {
        private IDataManger vehiclemappingDataManger;

        public vehiclemappingService(DataManger dataManger)
        {
            this.vehiclemappingDataManger = dataManger;
        }

        public IList<vehiclemapping> GetAllvehiclemappingData(vehiclemapping input)
        {
            var vehiclemappingData = vehiclemappingDataManger.GetAllvehiclemappingData(input);
            return vehiclemappingData;
        }
    }
}

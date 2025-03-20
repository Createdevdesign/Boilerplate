using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
  
    internal class HouseBankService : IHouseBankService
    {
        private IDataManger HouseBankDataManger;

        public HouseBankService(DataManger dataManger)
        {
            this.HouseBankDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllHouseBankData(SAPMaster input)
        {
            var HouseBankData = HouseBankDataManger.GetAllHouseBankData(input);
            return HouseBankData;
        }
    }
}

using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   

    internal class TabfieldsService : ITabfieldsService
    {
        private IDataManger TabfieldsDataManger;

        public TabfieldsService(DataManger dataManger)
        {
            this.TabfieldsDataManger = dataManger;
        }

        public IList<Tabfields> GetAllTabfieldsData(Tabfields input)
        {
            var TabfieldsData = TabfieldsDataManger.GetAllTabfieldsData(input);
            return TabfieldsData;
        }
    }
}

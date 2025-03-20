using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   

    internal class WIPApplicationListService : IWIPApplicationListService
    {
        private IDataManger WIPApplicationListDataManger;

        public WIPApplicationListService(DataManger dataManger)
        {
            this.WIPApplicationListDataManger = dataManger;
        }

        public IList<WIPApplicationList> GetAllWIPApplicationListData(WIPApplicationList input)
        {
            var WIPApplicationListData = WIPApplicationListDataManger.GetAllWIPApplicationListData(input);
            return WIPApplicationListData;
        }
    }
}

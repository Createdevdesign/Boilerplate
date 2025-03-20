using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    

    internal class RemarkListService : IRemarkListService
    {
        private IDataManger RemarkListDataManger;

        public RemarkListService(DataManger dataManger)
        {
            this.RemarkListDataManger = dataManger;
        }

        public IList<Remark> GetAllRemarkListData(Remark input)
        {
            var RemarkListData = RemarkListDataManger.GetAllRemarkListData(input);
            return RemarkListData;
        }
    }
}

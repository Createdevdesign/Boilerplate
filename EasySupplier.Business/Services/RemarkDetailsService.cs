using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   
    internal class RemarkDetailsService : IRemarkDetailsService
    {
        private IDataManger RemarkDetailsDataManger;

        public RemarkDetailsService(DataManger dataManger)
        {
            this.RemarkDetailsDataManger = dataManger;
        }

        public IList<Remark> GetRemarkByFieldID(Remark input)
        {
            var RemarkDetailsData = RemarkDetailsDataManger.GetRemarkByFieldID(input);
            return RemarkDetailsData;
        }
    }
}

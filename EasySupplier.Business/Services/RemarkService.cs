using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;
namespace BoilerSupplier.Business
{
   


    internal class RemarkService : IRemarkService
    {
        private IDataManger RemarkDataManger;

        public RemarkService(DataManger dataManger)
        {
            this.RemarkDataManger = dataManger;
        }

        public IList<Remark> GetAllRemarkData(Remark input)
        {
            var RemarkData = RemarkDataManger.GetAllRemarkData(input);
            return RemarkData;
        }
    }
}

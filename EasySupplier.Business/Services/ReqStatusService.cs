using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   

    internal class ReqStatusService : IReqStatusService
    {
        private IDataManger ReqStatusDataManger;

        public ReqStatusService(DataManger dataManger)
        {
            this.ReqStatusDataManger = dataManger;
        }

        public IList<ReqStatus> GetAllReqStatusData(ReqStatus input)
        {
            var ReqStatusData = ReqStatusDataManger.GetAllReqStatusData(input);
            return ReqStatusData;
        }
    }
}

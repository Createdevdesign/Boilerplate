using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{
   
    internal class ReqStatusRepository : Repository<ReqStatus>
    {
        public List<ReqStatus> GetAllReqStatusData(ReqStatus input)
        {
            ISelectionFactory<ReqStatus> selectionFactory = new ReqStatusSelectFactory();
            IDomainObjectFactory<ReqStatus> objectFactory = new ReqStatusObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

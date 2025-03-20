using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    

    internal class RemarkListRepository : Repository<Remark>
    {
        public List<Remark> GetAllRemarkListData(Remark input)
        {
            ISelectionFactory<Remark> selectionFactory = new RemarkListSelectFactory();
            IDomainObjectFactory<Remark> objectFactory = new RemarkListObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

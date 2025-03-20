using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    

    internal class RemarkRepository : Repository<Remark>
    {
        public List<Remark> GetAllRemarkData(Remark input)
        {
            ISelectionFactory<Remark> selectionFactory = new RemarkSelectFactory();
            IDomainObjectFactory<Remark> objectFactory = new RemarkObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

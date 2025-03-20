using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    

    internal class RemarkDetailsRepository : Repository<Remark>
    {
        public List<Remark> GetRemarkByFieldID(Remark input)
        {
            ISelectionFactory<Remark> selectionFactory = new RemarkDetailsSelectFactory();
            IDomainObjectFactory<Remark> objectFactory = new RemarkDetailsObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

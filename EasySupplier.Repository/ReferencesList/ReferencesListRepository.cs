using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository

{
  


    internal class ReferencesListRepository : Repository<Vendor>
    {
        public List<Vendor> GetAllReferencesListData(Vendor input)
        {
            ISelectionFactory<Vendor> selectionFactory = new ReferencesListSelectFactory();
            IDomainObjectFactory<Vendor> objectFactory = new ReferencesListObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

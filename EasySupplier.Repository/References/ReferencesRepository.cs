using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
   
    internal class ReferencesRepository : Repository<References>
    {
        public List<References> GetAllReferencesData(References input)
        {
            ISelectionFactory<References> selectionFactory = new ReferencesSelectFactory();
            IDomainObjectFactory<References> objectFactory = new ReferencesObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

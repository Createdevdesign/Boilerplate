using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    

    internal class NDAAppRepository : Repository<NDAApp>
    {
        public List<NDAApp> GetAllNDAAppData(NDAApp input)
        {
            ISelectionFactory<NDAApp> selectionFactory = new NDAAppSelectFactory();
            IDomainObjectFactory<NDAApp> objectFactory = new NDAAppObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

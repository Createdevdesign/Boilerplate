using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    

    internal class NDARepository : Repository<NDAApp>
    {
        public List<NDAApp> GetAllNDAData(NDAApp input)
        {
            ISelectionFactory<NDAApp> selectionFactory = new NDASelectFactory();
            IDomainObjectFactory<NDAApp> objectFactory = new NDAObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

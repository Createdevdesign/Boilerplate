using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Repository
{
    
    internal class TTLUseRepository : Repository<TTLUse>
    {
        public List<TTLUse> GetAllTTLUseData(TTLUse input)
        {
            ISelectionFactory<TTLUse> selectionFactory = new TTLUseSelectFactory();
            IDomainObjectFactory<TTLUse> objectFactory = new TTLUseObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

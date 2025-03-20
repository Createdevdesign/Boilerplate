using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{
   

    internal class TTLUseDetailRepository : Repository<TTLUse>
    {
        public List<TTLUse> GetAllTTLUseDetailData(TTLUse input)
        {
            ISelectionFactory<TTLUse> selectionFactory = new TTLUseDetailSelectFactory();
            IDomainObjectFactory<TTLUse> objectFactory = new TTLUseDetailObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

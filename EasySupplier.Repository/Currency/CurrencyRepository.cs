using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
   

    internal class CurrencyRepository : Repository<SAPMaster>
    {
        public List<SAPMaster> GetAllCurrencyData(SAPMaster input)
        {
            ISelectionFactory<SAPMaster> selectionFactory = new CurrencySelectFactory();
            IDomainObjectFactory<SAPMaster> objectFactory = new CurrencyObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

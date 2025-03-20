using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
   
    internal class merchantRepository : Repository<merchant>
    {
        public List<merchant> GetAllmerchantData(merchant input)
        {
            ISelectionFactory<merchant> selectionFactory = new merchantSelectFactory();
            IDomainObjectFactory<merchant> objectFactory = new merchantObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

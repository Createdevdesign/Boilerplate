using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
  

    internal class InvoiceRepository : Repository<Invoice>
    {
        public List<Invoice> GetAllInvoiceData(Invoice input)
        {
            ISelectionFactory<Invoice> selectionFactory = new InvoiceSelectFactory();
            IDomainObjectFactory<Invoice> objectFactory = new InvoiceObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

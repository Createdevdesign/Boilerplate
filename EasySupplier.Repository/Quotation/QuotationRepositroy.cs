using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
   

    internal class QuotationRepository : Repository<Quotation>
    {
        public List<Quotation> GetAllQuotationData(Quotation input)
        {
            ISelectionFactory<Quotation> selectionFactory = new QuotationSelectFactory();
            IDomainObjectFactory<Quotation> objectFactory = new QuotationObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }

        public Quotation InsertQuotation(Quotation input)
        {
            ISelectionFactory<Quotation> selectionFactory = new QuotationSelectFactory();
            IDomainObjectFactory<Quotation> objectFactory = new QuotationObjectFactory();
            return base.GetValue(selectionFactory, objectFactory, input);
        }
    }
}

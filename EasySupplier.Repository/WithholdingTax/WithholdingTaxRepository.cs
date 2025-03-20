using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{
   

    internal class WithholdingTaxRepository : Repository<WithholdingTax>
    {
        public List<WithholdingTax> GetAllWithholdingTaxData(WithholdingTax input)
        {
            ISelectionFactory<WithholdingTax> selectionFactory = new WithholdingTaxSelectFactory();
            IDomainObjectFactory<WithholdingTax> objectFactory = new WithholdingTaxObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{
   
    internal class WithholdingTaxListRepository : Repository<WithholdingTax>
    {
        public List<WithholdingTax> GetAllWithholdingTaxListData(WithholdingTax input)
        {
            ISelectionFactory<WithholdingTax> selectionFactory = new WithholdingTaxListSelectFactory();
            IDomainObjectFactory<WithholdingTax> objectFactory = new WithholdingTaxListObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }


        //7-9-2021
        public WithholdingTax GetWithholdingTaxListData(WithholdingTax input)
        {
            ISelectionFactory<WithholdingTax> selectionFactory = new WithholdingTaxListSelectFactory();
            IDomainObjectFactory<WithholdingTax> objectFactory = new WithholdingTaxListObjectFactory();
            return base.GetValue(selectionFactory, objectFactory, input);
        }
    }
}

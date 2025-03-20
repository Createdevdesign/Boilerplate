using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    

    internal class WithholdingTaxExeListRepository : Repository<WithholdingTaxExe>
    {
        public List<WithholdingTaxExe> GetAllWithholdingTaxExeListData(WithholdingTaxExe input)
        {
            ISelectionFactory<WithholdingTaxExe> selectionFactory = new WithholdingTaxExeListSelectFactory();
            IDomainObjectFactory<WithholdingTaxExe> objectFactory = new WithholdingTaxExeListObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }

        //7-9-2021
        public WithholdingTaxExe GetWithholdingTaxExeListData(WithholdingTaxExe input)
        {
            ISelectionFactory<WithholdingTaxExe> selectionFactory = new WithholdingTaxExeListSelectFactory();
            IDomainObjectFactory<WithholdingTaxExe> objectFactory = new WithholdingTaxExeListObjectFactory();
            return base.GetValue(selectionFactory, objectFactory, input);
        }
    }
}

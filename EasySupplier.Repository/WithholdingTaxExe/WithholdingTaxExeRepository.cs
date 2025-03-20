using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{
   

    internal class WithholdingTaxExeRepository : Repository<WithholdingTaxExe>
    {
        public List<WithholdingTaxExe> GetAllWithholdingTaxExeData(WithholdingTaxExe input)
        {
            ISelectionFactory<WithholdingTaxExe> selectionFactory = new WithholdingTaxExeSelectFactory();
            IDomainObjectFactory<WithholdingTaxExe> objectFactory = new WithholdingTaxExeObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

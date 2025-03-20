using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    

    internal class ApprovalRepository : Repository<Approval>
    {
        public Approval InsertApproval(Approval input)
        {
            ISelectionFactory<Approval> selectionFactory = new ApprovalSelectFactory();
            IDomainObjectFactory<Approval> objectFactory = new ApprovalObjectFactory();
            return base.GetValue(selectionFactory, objectFactory, input);
        }
    }
}

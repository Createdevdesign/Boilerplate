using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
   

    internal class SendBackRepository : Repository<SendBack>
    {
        public SendBack InsertSendBack(SendBack input)
        {
            ISelectionFactory<SendBack> selectionFactory = new SendBackSelectFactory();
            IDomainObjectFactory<SendBack> objectFactory = new SendBackObjectFactory();
            return base.GetValue(selectionFactory, objectFactory, input);
        }
    }
}

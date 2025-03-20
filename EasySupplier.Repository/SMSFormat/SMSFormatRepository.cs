using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{

    internal class SMSFormatRepository : Repository<SMSFormat>
    {
        public List<SMSFormat> GetAllSMSFormatData(SMSFormat input)
        {
            ISelectionFactory<SMSFormat> selectionFactory = new SMSFormatSelectFactory();
            IDomainObjectFactory<SMSFormat> objectFactory = new SMSFormatObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

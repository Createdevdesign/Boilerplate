using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
   
    internal class SMSFormatMappingRepository : Repository<SMSFormatMapping>
    {
        public List<SMSFormatMapping> GetAllSMSFormatMappingData(SMSFormatMapping input)
        {
            ISelectionFactory<SMSFormatMapping> selectionFactory = new SMSFormatMappingSelectFactory();
            IDomainObjectFactory<SMSFormatMapping> objectFactory = new SMSFormatMappingObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

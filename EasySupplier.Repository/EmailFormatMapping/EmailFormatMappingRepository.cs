using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{
   
    internal class EmailFormatMappingRepository : Repository<EmailFormatMapping>
    {
        public List<EmailFormatMapping> GetAllEmailFormatMappingData(EmailFormatMapping input)
        {
            ISelectionFactory<EmailFormatMapping> selectionFactory = new EmailFormatMappingSelectFactory();
            IDomainObjectFactory<EmailFormatMapping> objectFactory = new EmailFormatMappingObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

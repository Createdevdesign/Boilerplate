using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{
    
    internal class Email_FormatRepository : Repository<Email_Format>
    {
        public List<Email_Format> GetAllEmail_FormatData(Email_Format input)
        {
            ISelectionFactory<Email_Format> selectionFactory = new Email_FormatSelectFactory();
            IDomainObjectFactory<Email_Format> objectFactory = new Email_FormatObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

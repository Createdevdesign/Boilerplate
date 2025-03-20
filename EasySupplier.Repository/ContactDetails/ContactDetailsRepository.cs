using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{
    
    internal class ContactDetailsRepository : Repository<ContactDetail>
    {
        public List<ContactDetail> GetAllContactDetailsData(ContactDetail input)
        {
            ISelectionFactory<ContactDetail> selectionFactory = new ContactDetailsSelectFactory();
            IDomainObjectFactory<ContactDetail> objectFactory = new ContactDetailsObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

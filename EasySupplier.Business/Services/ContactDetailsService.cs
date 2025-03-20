using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
  
    internal class ContactDetailsService : IContactDetailsService
    {
        private IDataManger ContactDetailsDataManger;

        public ContactDetailsService(DataManger dataManger)
        {
            this.ContactDetailsDataManger = dataManger;
        }

        public IList<ContactDetail> GetAllContactDetailsData(ContactDetail input)
        {
            var ContactDetailsData = ContactDetailsDataManger.GetAllContactDetailsData(input);
            return ContactDetailsData;
        }
    }
}

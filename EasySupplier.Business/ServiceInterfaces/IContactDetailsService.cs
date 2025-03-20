using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface IContactDetailsService
    {
        /// <summary>
        /// Get all ContactDetails Master data
        /// </summary>
        /// <param name="input">ContactDetails Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<ContactDetail> GetAllContactDetailsData(ContactDetail input);
    }
}

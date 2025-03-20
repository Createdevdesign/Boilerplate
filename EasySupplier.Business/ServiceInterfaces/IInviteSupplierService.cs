using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface IInviteSupplierService
    {
        /// <summary>
        /// Get all InviteSupplier  data
        /// </summary>
        /// <param name="input">InviteSupplier Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<InviteSupplier> GetAllInviteSupplierData(InviteSupplier input);
    }
}

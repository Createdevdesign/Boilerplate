using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
  
    public interface IInviteService
    {
        /// <summary>
        /// Get all Invite  data
        /// </summary>
        /// <param name="input">Invite Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<Invite> GetAllInviteData(Invite input);
    }
}

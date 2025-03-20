using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
   
    public interface IUserService
    {
        /// <summary>
        /// Get all User Master data
        /// </summary>
        /// <param name="input">User Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<User> GetAllUserData(User input);
    }
}

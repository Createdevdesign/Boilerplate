using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
   
    public interface ISignupService
    {
        /// <summary>
        /// Get all Signup data
        /// </summary>
        /// <param name="input">Signup Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<Signup> GetAllSignupData(Signup input);

        Signup InsertSignupDetails(Signup input);
    }
}

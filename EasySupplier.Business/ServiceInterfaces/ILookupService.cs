using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface ILookupService
    {
        /// <summary>
        /// Get all Lookup Master data
        /// </summary>
        /// <param name="input">Lookup Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<Lookup> GetAllLookupMasterData(Lookup input);
    }
}

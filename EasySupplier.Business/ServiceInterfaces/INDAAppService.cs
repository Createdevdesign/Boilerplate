using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    

    public interface INDAAppService
    {
        /// <summary>
        /// Get all NDAApp Master data
        /// </summary>
        /// <param name="input">NDAApp Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<NDAApp> GetAllNDAAppData(NDAApp input);
    }
}

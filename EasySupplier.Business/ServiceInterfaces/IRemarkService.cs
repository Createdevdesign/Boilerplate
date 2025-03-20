using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
  

    public interface IRemarkService
    {
        /// <summary>
        /// Get all Remark  data
        /// </summary>
        /// <param name="input">Remark Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<Remark> GetAllRemarkData(Remark input);
    }
}

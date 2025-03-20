using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    

    public interface IReqStatusService
    {
        /// <summary>
        /// Get all ReqStatus data
        /// </summary>
        /// <param name="input">ReqStatus Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<ReqStatus> GetAllReqStatusData(ReqStatus input);
    }
}

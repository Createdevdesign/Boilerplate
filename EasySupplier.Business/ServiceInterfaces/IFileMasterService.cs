using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
   
    public interface IFileMasterService
    {
        /// <summary>
        /// Get all FileMaster Master data
        /// </summary>
        /// <param name="input">FileMaster Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<FileMaster> GetAllFileMasterData(FileMaster input);
    }
}

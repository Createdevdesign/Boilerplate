using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
   

    public interface IFileUploadService
    {
        /// <summary>
        /// Get all FileUpload  data
        /// </summary>
        /// <param name="input">FileUpload Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<FileUpload> GetAllFileUploadData(FileUpload input);
    }
}

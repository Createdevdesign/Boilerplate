using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
  

    internal class FileUploadObjectFactory : IDomainObjectFactory<FileUpload>
    {
        public FileUpload Construct(IDataReader reader)
        {
            FileUpload FileUpload = new FileUpload();

           
            return FileUpload;
        }
    }
}

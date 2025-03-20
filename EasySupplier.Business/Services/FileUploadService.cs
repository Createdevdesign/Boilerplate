using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace BoilerSupplier.Business
{
    

    internal class FileUploadService : IFileUploadService
    {
        private IDataManger FileUploadDataManger;

        public FileUploadService(DataManger dataManger)
        {
            this.FileUploadDataManger = dataManger;
        }

        public IList<FileUpload> GetAllFileUploadData(FileUpload input)
        {
            var FileUploadData = FileUploadDataManger.GetAllFileUploadData(input);
            return FileUploadData;
        }
    }
}

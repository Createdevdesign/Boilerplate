using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace BoilerSupplier.Business
{
    
    internal class FileFieldService : IFileFieldService
    {
        private IDataManger FileFieldDataManger;

        public FileFieldService(DataManger dataManger)
        {
            this.FileFieldDataManger = dataManger;
        }

        public IList<FileField> GetAllFileFieldData(FileField input)
        {
            var FileFieldData = FileFieldDataManger.GetAllFileFieldData(input);
            return FileFieldData;
        }
    }
}

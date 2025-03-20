using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   
    internal class FileSchemaService : IFileSchemaService
    {
        private IDataManger FileSchemaDataManger;

        public FileSchemaService(DataManger dataManger)
        {
            this.FileSchemaDataManger = dataManger;
        }

        public IList<FileSchema> GetAllFileSchemaData(FileSchema input)
        {
            var FileSchemaData = FileSchemaDataManger.GetAllFileSchemaData(input);
            return FileSchemaData;
        }
    }
}

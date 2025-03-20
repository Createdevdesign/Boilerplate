using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    internal class FileMasterService : IFileMasterService
    {
        private IDataManger FileMasterDataManger;

        public FileMasterService(DataManger dataManger)
        {
            this.FileMasterDataManger = dataManger;
        }

        public IList<FileMaster> GetAllFileMasterData(FileMaster input)
        {
            var FileMasterData = FileMasterDataManger.GetAllFileMasterData(input);
            return FileMasterData;
        }
    }
}

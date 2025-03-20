using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    internal class LookupService : ILookupService
    {
        private IDataManger lookupDataManger;

        public LookupService(DataManger dataManger)
        {
            this.lookupDataManger = dataManger;
        }

        public IList<Lookup> GetAllLookupMasterData(Lookup input)
        {
            var LookupMasterData = lookupDataManger.GetAllLookupMasterData(input);
            return LookupMasterData;
        }
    }
}

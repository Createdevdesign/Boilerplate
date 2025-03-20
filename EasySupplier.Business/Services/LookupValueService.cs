using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   
    internal class LookupValueService : ILookupValueService
    {
        private IDataManger lookupValueDataManger;

        public LookupValueService(DataManger dataManger)
        {
            this.lookupValueDataManger = dataManger;
        }

        public IList<LookupValue> GetAllLookupValueData(LookupValue input)
        {
            var LookupValueData = lookupValueDataManger.GetAllLookupValueData(input);
            return LookupValueData;
        }
    }
}

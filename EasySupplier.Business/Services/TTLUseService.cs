using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   
    internal class TTLUseService : ITTLUseService
    {
        private IDataManger TTLUseDataManger;

        public TTLUseService(DataManger dataManger)
        {
            this.TTLUseDataManger = dataManger;
        }

        public IList<TTLUse> GetAllTTLUseData(TTLUse input)
        {
            var TTLUseData = TTLUseDataManger.GetAllTTLUseData(input);
            return TTLUseData;
        }
    }
}

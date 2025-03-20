using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   
    internal class TTLUseDetailService : ITTLUseDetailService
    {
        private IDataManger TTLUseDetailDataManger;

        public TTLUseDetailService(DataManger dataManger)
        {
            this.TTLUseDetailDataManger = dataManger;
        }

        public IList<TTLUse> GetAllTTLUseDetailData(TTLUse input)
        {
            var TTLUseDetailData = TTLUseDetailDataManger.GetAllTTLUseDetailData(input);
            return TTLUseDetailData;
        }

       
    }
}

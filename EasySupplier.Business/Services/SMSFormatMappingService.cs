using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   
    internal class SMSFormatMappingService : ISMSFormatMappingService
    {
        private IDataManger SMSFormatMappingDataManger;

        public SMSFormatMappingService(DataManger dataManger)
        {
            this.SMSFormatMappingDataManger = dataManger;
        }

        public IList<SMSFormatMapping> GetAllSMSFormatMappingData(SMSFormatMapping input)
        {
            var SMSFormatMappingData = SMSFormatMappingDataManger.GetAllSMSFormatMappingData(input);
            return SMSFormatMappingData;
        }
    }
}

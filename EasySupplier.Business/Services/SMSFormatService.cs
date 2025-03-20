using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   
    internal class SMSFormatService : ISMSFormatService
    {
        private IDataManger SMSFormatDataManger;

        public SMSFormatService(DataManger dataManger)
        {
            this.SMSFormatDataManger = dataManger;
        }

        public IList<SMSFormat> GetAllSMSFormatData(SMSFormat input)
        {
            var SMSFormatData = SMSFormatDataManger.GetAllSMSFormatData(input);
            return SMSFormatData;
        }
    }
}

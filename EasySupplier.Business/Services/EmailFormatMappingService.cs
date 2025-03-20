using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    
    internal class EmailFormatMappingService : IEmailFormatMappingService
    {
        private IDataManger EmailFormatMappingDataManger;

        public EmailFormatMappingService(DataManger dataManger)
        {
            this.EmailFormatMappingDataManger = dataManger;
        }

        public IList<EmailFormatMapping> GetAllEmailFormatMappingData(EmailFormatMapping input)
        {
            var EmailFormatMappingData = EmailFormatMappingDataManger.GetAllEmailFormatMappingData(input);
            return EmailFormatMappingData;
        }
    }
}

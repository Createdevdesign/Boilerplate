using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   
    internal class Email_FormatService : IEmail_FormatService
    {
        private IDataManger Email_FormatDataManger;

        public Email_FormatService(DataManger dataManger)
        {
            this.Email_FormatDataManger = dataManger;
        }

        public IList<Email_Format> GetAllEmail_FormatData(Email_Format input)
        {
            var Email_FormatData = Email_FormatDataManger.GetAllEmail_FormatData(input);
            return Email_FormatData;
        }
    }
}

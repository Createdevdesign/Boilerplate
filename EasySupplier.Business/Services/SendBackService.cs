
using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    

    internal class SendBackService : ISendBackService
    {
        private IDataManger SendBackDataManger;

        public SendBackService(DataManger dataManger)
        {
            this.SendBackDataManger = dataManger;
        }

        public SendBack InsertSendBack(SendBack input)
        {
            return SendBackDataManger.InsertSendBack(input);
        }
    }
}

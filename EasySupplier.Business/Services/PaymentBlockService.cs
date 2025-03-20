using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   
    internal class PaymentBlockService : IPaymentBlockService
    {
        private IDataManger PaymentBlockDataManger;

        public PaymentBlockService(DataManger dataManger)
        {
            this.PaymentBlockDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllPaymentBlockData(SAPMaster input)
        {
            var PaymentBlockData = PaymentBlockDataManger.GetAllPaymentBlockData(input);
            return PaymentBlockData;
        }
    }
}

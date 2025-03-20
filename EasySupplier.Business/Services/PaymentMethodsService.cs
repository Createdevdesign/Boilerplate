using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
  
    internal class PaymentMethodsService : IPaymentMethodsService
    {
        private IDataManger PaymentMethodsDataManger;

        public PaymentMethodsService(DataManger dataManger)
        {
            this.PaymentMethodsDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllPaymentMethodsData(SAPMaster input)
        {
            var PaymentMethodsData = PaymentMethodsDataManger.GetAllPaymentMethodsData(input);
            return PaymentMethodsData;
        }
    }
}

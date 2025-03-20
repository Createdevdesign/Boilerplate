using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
 
    

    internal class PaymentTermService : IPaymentTermService
    {
        private IDataManger PaymentTermDataManger;

        public PaymentTermService(DataManger dataManger)
        {
            this.PaymentTermDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllPaymentTermData(SAPMaster input)
        {
            var PaymentTermData = PaymentTermDataManger.GetAllPaymentTermData(input);
            return PaymentTermData;
        }
    }
}

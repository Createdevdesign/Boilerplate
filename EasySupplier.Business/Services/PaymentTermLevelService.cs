using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace BoilerSupplier.Business
{
   

    internal class PaymentTermLevelService : IPaymentTermLevelService
    {
        private IDataManger PaymentTermLevelDataManger;

        public PaymentTermLevelService(DataManger dataManger)
        {
            this.PaymentTermLevelDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllPaymentTermLevelData(SAPMaster input)
        {
            var PaymentTermLevelData = PaymentTermLevelDataManger.GetAllPaymentTermLevelData(input);
            return PaymentTermLevelData;
        }
    }
}

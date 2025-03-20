using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
  
    internal class ReconciliationAccountService : IReconciliationAccountService
    {
        private IDataManger ReconciliationAccountDataManger;

        public ReconciliationAccountService(DataManger dataManger)
        {
            this.ReconciliationAccountDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllReconciliationAccountData(SAPMaster input)
        {
            var ReconciliationAccountData = ReconciliationAccountDataManger.GetAllReconciliationAccountData(input);
            return ReconciliationAccountData;
        }
    }
}

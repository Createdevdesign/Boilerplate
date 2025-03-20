using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   
    internal class BankKeyService : IBankKeyService
    {
        private IDataManger BankKeyDataManger;

        public BankKeyService(DataManger dataManger)
        {
            this.BankKeyDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllBankKeyData(SAPMaster input)
        {
            var BankKeyData = BankKeyDataManger.GetAllBankKeyData(input);
            return BankKeyData;
        }
    }
}

using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
  
    internal class BankingDetailsService : IBankingDetailsService
    {
        private IDataManger BankingDetailsDataManger;

        public BankingDetailsService(DataManger dataManger)
        {
            this.BankingDetailsDataManger = dataManger;
        }

        public IList<BankingDetail> GetAllBankingDetailsData(BankingDetail input)
        {
            var BankingDetailsData = BankingDetailsDataManger.GetAllBankingDetailsData(input);
            return BankingDetailsData;
        }
    }
}

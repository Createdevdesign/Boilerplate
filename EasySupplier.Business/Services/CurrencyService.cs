using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   

    internal class CurrencyService : ICurrencyService
    {
        private IDataManger CurrencyDataManger;

        public CurrencyService(DataManger dataManger)
        {
            this.CurrencyDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllCurrencyData(SAPMaster input)
        {
            var CurrencyData = CurrencyDataManger.GetAllCurrencyData(input);
            return CurrencyData;
        }
    }
}

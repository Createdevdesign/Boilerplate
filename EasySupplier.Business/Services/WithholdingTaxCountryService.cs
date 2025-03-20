using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace BoilerSupplier.Business
{
    
    internal class WithholdingTaxCountryService : IWithholdingTaxCountryService
    {
        private IDataManger WithholdingTaxCountryDataManger;

        public WithholdingTaxCountryService(DataManger dataManger)
        {
            this.WithholdingTaxCountryDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllWithholdingTaxCountryData(SAPMaster input)
        {
            var WithholdingTaxCountryData = WithholdingTaxCountryDataManger.GetAllWithholdingTaxCountryData(input);
            return WithholdingTaxCountryData;
        }
    }
}

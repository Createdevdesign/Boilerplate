using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
  
    internal class WithholdingTaxCodeExemptionService : IWithholdingTaxCodeExemptionService
    {
        private IDataManger WithholdingTaxCodeExemptionDataManger;

        public WithholdingTaxCodeExemptionService(DataManger dataManger)
        {
            this.WithholdingTaxCodeExemptionDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllWithholdingTaxCodeExemptionData(SAPMaster input)
        {
            var WithholdingTaxCodeExemptionData = WithholdingTaxCodeExemptionDataManger.GetAllWithholdingTaxCodeExemptionData(input);
            return WithholdingTaxCodeExemptionData;
        }
    }
}

using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   

    internal class WithholdingTaxTypeExemptionService : IWithholdingTaxTypeExemptionService
    {
        private IDataManger WithholdingTaxTypeExemptionDataManger;

        public WithholdingTaxTypeExemptionService(DataManger dataManger)
        {
            this.WithholdingTaxTypeExemptionDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllWithholdingTaxTypeExemptionData(SAPMaster input)
        {
            var WithholdingTaxTypeExemptionData = WithholdingTaxTypeExemptionDataManger.GetAllWithholdingTaxTypeExemptionData(input);
            return WithholdingTaxTypeExemptionData;
        }
    }
}

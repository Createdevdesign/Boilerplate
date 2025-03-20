using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    
    internal class WithholdingTaxTypeService : IWithholdingTaxTypeService
    {
        private IDataManger WithholdingTaxTypeDataManger;

        public WithholdingTaxTypeService(DataManger dataManger)
        {
            this.WithholdingTaxTypeDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllWithholdingTaxTypeData(SAPMaster input)
        {
            var WithholdingTaxTypeData = WithholdingTaxTypeDataManger.GetAllWithholdingTaxTypeData(input);
            return WithholdingTaxTypeData;
        }
    }
}

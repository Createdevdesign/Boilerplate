using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   
    internal class WithholdingTaxCodeService : IWithholdingTaxCodeService
    {
        private IDataManger WithholdingTaxCodeDataManger;

        public WithholdingTaxCodeService(DataManger dataManger)
        {
            this.WithholdingTaxCodeDataManger = dataManger;
        }

        public IList<SAPMaster> GetAllWithholdingTaxCodeData(SAPMaster input)
        {
            var WithholdingTaxCodeData = WithholdingTaxCodeDataManger.GetAllWithholdingTaxCodeData(input);
            return WithholdingTaxCodeData;
        }
    }
}

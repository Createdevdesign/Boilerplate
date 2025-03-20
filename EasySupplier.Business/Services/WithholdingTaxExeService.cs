using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace BoilerSupplier.Business
{
    
    internal class WithholdingTaxExeService : IWithholdingTaxExeService
    {
        private IDataManger WithholdingTaxExeDataManger;

        public WithholdingTaxExeService(DataManger dataManger)
        {
            this.WithholdingTaxExeDataManger = dataManger;
        }

        public IList<WithholdingTaxExe> GetAllWithholdingTaxExeData(WithholdingTaxExe input)
        {
            var WithholdingTaxExeData = WithholdingTaxExeDataManger.GetAllWithholdingTaxExeData(input);
            return WithholdingTaxExeData;
        }
    }
}

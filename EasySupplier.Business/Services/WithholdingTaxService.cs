using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace BoilerSupplier.Business
{
    
    internal class WithholdingTaxService : IWithholdingTaxService
    {
        private IDataManger WithholdingTaxDataManger;

        public WithholdingTaxService(DataManger dataManger)
        {
            this.WithholdingTaxDataManger = dataManger;
        }

        public IList<WithholdingTax> GetAllWithholdingTaxData(WithholdingTax input)
        {
            var WithholdingTaxData = WithholdingTaxDataManger.GetAllWithholdingTaxData(input);
            return WithholdingTaxData;
        }
    }
}

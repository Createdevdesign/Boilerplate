using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace BoilerSupplier.Business
{
 

    internal class WithholdingTaxListService : IWithholdingTaxListService
    {
        private IDataManger WithholdingTaxListDataManger;

        public WithholdingTaxListService(DataManger dataManger)
        {
            this.WithholdingTaxListDataManger = dataManger;
        }

        public IList<WithholdingTax> GetAllWithholdingTaxListData(WithholdingTax input)
        {
            var WithholdingTaxListData = WithholdingTaxListDataManger.GetAllWithholdingTaxListData(input);
            return WithholdingTaxListData;
        }

        public WithholdingTax GetWithholdingTaxListData(WithholdingTax input)
        {
            return WithholdingTaxListDataManger.GetWithholdingTaxListData(input);
        }
    }
}

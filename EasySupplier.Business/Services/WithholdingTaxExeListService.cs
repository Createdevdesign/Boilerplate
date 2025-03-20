using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    

    internal class WithholdingTaxExeListService : IWithholdingTaxExeListService
    {
        private IDataManger WithholdingTaxExeListDataManger;

        public WithholdingTaxExeListService(DataManger dataManger)
        {
            this.WithholdingTaxExeListDataManger = dataManger;
        }

        public IList<WithholdingTaxExe> GetAllWithholdingTaxExeListData(WithholdingTaxExe input)
        {
            var WithholdingTaxExeListData = WithholdingTaxExeListDataManger.GetAllWithholdingTaxExeListData(input);
            return WithholdingTaxExeListData;
        }

        public WithholdingTaxExe GetWithholdingTaxExeListData(WithholdingTaxExe input)
        {
            return WithholdingTaxExeListDataManger.GetWithholdingTaxExeListData(input);
        }
    }
}

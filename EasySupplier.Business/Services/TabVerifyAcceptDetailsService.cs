using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
  
    internal class TabVerifyAcceptDetailsService : ITabVerifyAcceptDetailsService
    {
        private IDataManger TabVerifyAcceptDetailsDataManger;

        public TabVerifyAcceptDetailsService(DataManger dataManger)
        {
            this.TabVerifyAcceptDetailsDataManger = dataManger;
        }

        public IList<TabVerifyAccept> GetTabVerifyAcceptDetails(TabVerifyAccept input)
        {
            var TabVerifyAcceptDetailsData = TabVerifyAcceptDetailsDataManger.GetTabVerifyAcceptDetails(input);
            return TabVerifyAcceptDetailsData;
        }
    }
}

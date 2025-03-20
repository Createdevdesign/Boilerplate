using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    

    internal class TabVerifyAcceptService : ITabVerifyAcceptService
    {
        private IDataManger TabVerifyAcceptDataManger;

        public TabVerifyAcceptService(DataManger dataManger)
        {
            this.TabVerifyAcceptDataManger = dataManger;
        }       

        public TabVerifyAccept InsertTabVerifyAccept(TabVerifyAccept input)
        {
            return TabVerifyAcceptDataManger.InsertTabVerifyAccept(input);
        }
    }
}

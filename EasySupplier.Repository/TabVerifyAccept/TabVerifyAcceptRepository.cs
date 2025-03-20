using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
   

    internal class TabVerifyAcceptRepository : Repository<TabVerifyAccept>
    {
      

        public TabVerifyAccept InsertTabVerifyAccept(TabVerifyAccept input)
        {
            ISelectionFactory<TabVerifyAccept> selectionFactory = new TabVerifyAcceptSelectFactory();
            IDomainObjectFactory<TabVerifyAccept> objectFactory = new TabVerifyAcceptObjectFactory();
            return base.GetValue(selectionFactory, objectFactory, input);
        }
    }
}

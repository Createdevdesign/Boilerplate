using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
   

    internal class TabVerifyAcceptDetailsRepository : Repository<TabVerifyAccept>
    {

        public List<TabVerifyAccept> GetTabVerifyAcceptDetails(TabVerifyAccept input)
        {
            ISelectionFactory<TabVerifyAccept> selectionFactory = new TabVerifyAcceptDetailsSelectFactory();
            IDomainObjectFactory<TabVerifyAccept> objectFactory = new TabVerifyAcceptDetailsObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }


    }
}

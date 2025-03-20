using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace BoilerSupplier.Business
{
 

    internal class SubMenuService : ISubMenuService
    {
        private IDataManger SubMenuDataManger;

        public SubMenuService(DataManger dataManger)
        {
            this.SubMenuDataManger = dataManger;
        }

        public IList<SubMenu> GetAllSubMenuData(SubMenu input)
        {
            var SubMenuData = SubMenuDataManger.GetAllSubMenuData(input);
            return SubMenuData;
        }
    }
}

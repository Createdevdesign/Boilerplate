using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
    
    internal class MainMenuService : IMainMenuService
    {
        private IDataManger MainMenuDataManger;

        public MainMenuService(DataManger dataManger)
        {
            this.MainMenuDataManger = dataManger;
        }

        public IList<MainMenu> GetAllMainMenuData(MainMenu input)
        {
            var MainMenuData = MainMenuDataManger.GetAllMainMenuData(input);
            return MainMenuData;
        }
    }
}

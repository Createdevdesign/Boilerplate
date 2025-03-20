using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    internal class MainMenuObjectFactory : IDomainObjectFactory<MainMenu>
    {
        public MainMenu Construct(IDataReader reader)
        {
            MainMenu MainMenu = new MainMenu();
            MainMenu.MainMenuName = null != reader[Constants.OUT_MAIN_MENU_NAME] ? reader[Constants.OUT_MAIN_MENU_NAME].ToString().Trim() : string.Empty;
            MainMenu.MenuOrder = null != reader[Constants.OUT_MENU_ORDER] ? Convert.ToDecimal(reader[Constants.OUT_MENU_ORDER].ToString().Trim()) : 0;
            MainMenu.ServicesID = null != reader[Constants.OUT_SERVICES_ID] ? Convert.ToDecimal(reader[Constants.OUT_SERVICES_ID].ToString().Trim()) : 0;
            MainMenu.ModuleName = null != reader[Constants.OUT_MODULE_NAME] ? reader[Constants.OUT_MODULE_NAME].ToString().Trim() : string.Empty;
            MainMenu.ModuleId = null != reader[Constants.OUT_MODULE_ID] ? reader[Constants.OUT_MODULE_ID].ToString().Trim() : string.Empty;
            MainMenu.icon = null != reader[Constants.OUT_ICON] ? reader[Constants.OUT_ICON].ToString().Trim() : string.Empty;
             
            MainMenu.IsActive = DBNull.Value != reader[Constants.OUT_IS_ACTIVE_YN] ? Convert.ToBoolean(reader[Constants.OUT_IS_ACTIVE_YN].ToString().Trim()) : false;
           
            return MainMenu;
        }
    }
}

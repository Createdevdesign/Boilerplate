using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   
    internal class SubMenuObjectFactory : IDomainObjectFactory<SubMenu>
    {
        public SubMenu Construct(IDataReader reader)
        {
            SubMenu SubMenu = new SubMenu();

            
            SubMenu.varScreenTitle = null != reader[Constants.OUT_VAR_SCREEN_TITLE] ? reader[Constants.OUT_VAR_SCREEN_TITLE].ToString().Trim() : string.Empty;
            SubMenu.varPageName = null != reader[Constants.OUT_VAR_PAGE_NAME] ? reader[Constants.OUT_VAR_PAGE_NAME].ToString().Trim() : string.Empty;
            SubMenu.MainMenuId = null != reader[Constants.OUT_MAIN_MENU_ID] ? Convert.ToInt32(reader[Constants.OUT_MAIN_MENU_ID].ToString().Trim()) : 0;
            SubMenu.Intorderno = null != reader[Constants.OUT_INTORDER_NO] ? Convert.ToDecimal(reader[Constants.OUT_INTORDER_NO].ToString().Trim()) : 0;
            SubMenu.ServicesId = null != reader[Constants.OUT_SERVICES_ID] ? Convert.ToDecimal(reader[Constants.OUT_SERVICES_ID].ToString().Trim()) : 0;
            SubMenu.AngularUrl = null != reader[Constants.OUT_ANGULAR_URL] ? reader[Constants.OUT_ANGULAR_URL].ToString().Trim() : string.Empty;
            SubMenu.ModifiedDate = null != reader[Constants.OUT_MODIFIED_DATE] ? Convert.ToDateTime(reader[Constants.OUT_MODIFIED_DATE].ToString().Trim()) : DateTime.Today;
            SubMenu.ModifiedUser = null != reader[Constants.OUT_MODIFIED_USER] ? reader[Constants.OUT_MODIFIED_USER].ToString().Trim() : string.Empty;
            SubMenu.IsActive = DBNull.Value != reader[Constants.OUT_IS_ACTIVE_YN] ? Convert.ToBoolean(reader[Constants.OUT_IS_ACTIVE_YN].ToString().Trim()) : false;
              return SubMenu;
        }
    }
}

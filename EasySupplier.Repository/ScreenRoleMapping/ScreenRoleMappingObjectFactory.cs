using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;


namespace BoilerSupplier.Repository
{
    

    internal class ScreenRoleMappingObjectFactory : IDomainObjectFactory<ScreenRoleMapping>
    {
        public ScreenRoleMapping Construct(IDataReader reader)
        {
            ScreenRoleMapping ScreenRoleMapping = new ScreenRoleMapping();

            ScreenRoleMapping.SubMenuId = null != reader[Constants.OUT_SUB_MENU_ID] ? Convert.ToInt32(reader[Constants.OUT_SUB_MENU_ID].ToString().Trim()) : 0;
            ScreenRoleMapping.RoleId = null != reader[Constants.OUT_ROLE_ID] ? Convert.ToInt32(reader[Constants.OUT_ROLE_ID].ToString().Trim()) : 0;
            ScreenRoleMapping.ServicesId = null != reader[Constants.OUT_SERVICES_ID] ? Convert.ToDecimal(reader[Constants.OUT_SERVICES_ID].ToString().Trim()) : 0;
            ScreenRoleMapping.IsActive = DBNull.Value != reader[Constants.OUT_IS_ACTIVE_YN] ? Convert.ToBoolean(reader[Constants.OUT_IS_ACTIVE_YN].ToString().Trim()) : false;
     
            return ScreenRoleMapping;
        }
    }
}

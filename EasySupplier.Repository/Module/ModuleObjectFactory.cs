
using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
  
    internal class ModuleObjectFactory : IDomainObjectFactory<ModuleMaster>
    {
        public ModuleMaster Construct(IDataReader reader)
        {
            ModuleMaster ModuleMaster = new ModuleMaster();

            ModuleMaster.ModuleName = null != reader[Constants.OUT_MODULE_NAME] ? reader[Constants.OUT_MODULE_NAME].ToString().Trim() : string.Empty;
            ModuleMaster.ServicesId = null != reader[Constants.OUT_SERVICES_ID] ? Convert.ToDecimal(reader[Constants.OUT_SERVICES_ID].ToString().Trim()) : 0;
            ModuleMaster.icon = null != reader[Constants.OUT_ICON] ? reader[Constants.OUT_ICON].ToString().Trim() : string.Empty;
            ModuleMaster.ModuleOrder = null != reader[Constants.OUT_MODULE_ORDER] ? Convert.ToDecimal(reader[Constants.OUT_MODULE_ORDER].ToString().Trim()) : 0;
            ModuleMaster.ModuleAssign = null != reader[Constants.OUT_MODULE_ASSIGN] ? reader[Constants.OUT_MODULE_ASSIGN].ToString().Trim() : string.Empty;
            ModuleMaster.IsActive = DBNull.Value != reader[Constants.OUT_IS_ACTIVE_YN] ? Convert.ToBoolean(reader[Constants.OUT_IS_ACTIVE_YN].ToString().Trim()) : false;
           
            return ModuleMaster;
        }
    }
}

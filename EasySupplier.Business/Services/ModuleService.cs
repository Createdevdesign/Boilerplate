using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace BoilerSupplier.Business
{
    
    internal class ModuleService : IModuleService
    {
        private IDataManger ModuleDataManger;

        public ModuleService(DataManger dataManger)
        {
            this.ModuleDataManger = dataManger;
        }

        public IList<ModuleMaster> GetAllModuleData(ModuleMaster input)
        {
            var ModuleData = ModuleDataManger.GetAllModuleData(input);
            return ModuleData;
        }
    }
}

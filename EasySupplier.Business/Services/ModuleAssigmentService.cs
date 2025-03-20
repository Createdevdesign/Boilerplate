using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
  
    internal class ModuleAssigmentService : IModuleAssigmentService
    {
        private IDataManger ModuleAssigmentDataManger;

        public ModuleAssigmentService(DataManger dataManger)
        {
            this.ModuleAssigmentDataManger = dataManger;
        }

        public IList<Module_Assigment> GetAllModuleAssigmentData(Module_Assigment input)
        {
            var ModuleAssigmentData = ModuleAssigmentDataManger.GetAllModuleAssigmentData(input);
            return ModuleAssigmentData;
        }
    }
}

using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace BoilerSupplier.Business
{
    
    internal class ScreenRoleMappingService : IScreenRoleMappingService
    {
        private IDataManger ScreenRoleMappingDataManger;

        public ScreenRoleMappingService(DataManger dataManger)
        {
            this.ScreenRoleMappingDataManger = dataManger;
        }

        public IList<ScreenRoleMapping> GetAllScreenRoleMappingData(ScreenRoleMapping input)
        {
            var ScreenRoleMappingData = ScreenRoleMappingDataManger.GetAllScreenRoleMappingData(input);
            return ScreenRoleMappingData;
        }
    }
}

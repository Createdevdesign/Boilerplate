using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{

    internal class ConfigrationService : IConfigrationService
    {
        private IDataManger ConfigrationDataManger;

        public ConfigrationService(DataManger dataManger)
        {
            this.ConfigrationDataManger = dataManger;
        }

        public IList<ConfigrationMaster> GetAllConfigrationData(ConfigrationMaster input)
        {
            var ConfigrationData = ConfigrationDataManger.GetAllConfigrationData(input);
            return ConfigrationData;
        }
    }
}

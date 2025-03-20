using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;



namespace BoilerSupplier.Business
{
    internal class OperationalConfigrationService : IOperationalConfigrationService
    {
        private IDataManger OperationalConfigrationDataManger;

        public OperationalConfigrationService(DataManger dataManger)
        {
            this.OperationalConfigrationDataManger = dataManger;
        }

        public IList<OperationalConfigrationMaster> GetAllOperationalConfigrationData(OperationalConfigrationMaster input)
        {
            var OperationalConfigrationData = OperationalConfigrationDataManger.GetAllOperationalConfigrationData(input);
            return OperationalConfigrationData;
        }
    }
}

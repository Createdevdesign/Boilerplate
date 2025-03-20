using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;


namespace BoilerSupplier.Repository
{
    internal class OperationalConfigrationRepository : Repository<OperationalConfigrationMaster>
    {
        public List<OperationalConfigrationMaster> GetAllOperationalConfigrationData(OperationalConfigrationMaster input)
        {
            ISelectionFactory<OperationalConfigrationMaster> selectionFactory = new OperationalConfigrationSelectFactory();
            IDomainObjectFactory<OperationalConfigrationMaster> objectFactory = new OperationalConfigrationObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

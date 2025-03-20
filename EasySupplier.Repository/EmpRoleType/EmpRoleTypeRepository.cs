using BoilerSupplier.DataTransferObject;
using System.Collections.Generic;

namespace BoilerSupplier.Repository
{
    
    internal class EmpRoleTypeRepository : Repository<EmpRole>
    {
        public List<EmpRole> GetEmpRoleTypeData(EmpRole input)
        {
            ISelectionFactory<EmpRole> selectionFactory = new EmpRoleTypeSelectFactory();
            IDomainObjectFactory<EmpRole> objectFactory = new EmpRoleTypeObjectFactory();
            return base.GetAll(selectionFactory, objectFactory, input);
        }
    }
}

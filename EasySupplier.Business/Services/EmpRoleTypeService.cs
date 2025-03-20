using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;


namespace BoilerSupplier.Business
{
    

    internal class EmpRoleTypeService : IEmpRoleTypeService
    {
        private IDataManger EmpRoleTypeDataManger;

        public EmpRoleTypeService(DataManger dataManger)
        {
            this.EmpRoleTypeDataManger = dataManger;
        }

        public IList<EmpRole> GetEmpRoleTypeData(EmpRole input)
        {
            var EmpRoleTypeData = EmpRoleTypeDataManger.GetEmpRoleTypeData(input);
            return EmpRoleTypeData;
        }
    }
}

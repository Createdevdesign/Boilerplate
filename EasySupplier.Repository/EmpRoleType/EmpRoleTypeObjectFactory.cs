using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   
    internal class EmpRoleTypeObjectFactory : IDomainObjectFactory<EmpRole>
    {
        public EmpRole Construct(IDataReader reader)
        {
            EmpRole EmpRoleType = new EmpRole();


            EmpRoleType.EmpID = null != reader[Constants.OUT_EmpID] ? Convert.ToInt32(reader[Constants.OUT_EmpID].ToString().Trim()) : 0;
            EmpRoleType.UserRoleType = null != reader[Constants.OUT_UserRoleType] ? Convert.ToInt32(reader[Constants.OUT_UserRoleType].ToString().Trim()) : 0;

            return EmpRoleType;
        }
    }
}

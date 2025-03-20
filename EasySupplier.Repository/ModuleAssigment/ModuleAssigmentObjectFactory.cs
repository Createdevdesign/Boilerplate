using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    internal class ModuleAssigmentObjectFactory : IDomainObjectFactory<Module_Assigment>
    {
        public Module_Assigment Construct(IDataReader reader)
        {
            Module_Assigment Module_Assigment = new Module_Assigment();

            Module_Assigment.ACQ_ID = null != reader[Constants.OUT_ACQ_ID] ? Convert.ToDecimal(reader[Constants.OUT_ACQ_ID].ToString().Trim()) : 0;
            Module_Assigment.Module = null != reader[Constants.OUT_MODULE] ? Convert.ToDecimal(reader[Constants.OUT_MODULE].ToString().Trim()) : 0;
            Module_Assigment.Status = DBNull.Value != reader[Constants.OUT_STATUS_YN] ? Convert.ToBoolean(reader[Constants.OUT_STATUS_YN].ToString().Trim()) : false;
          
            return Module_Assigment;
        }
    }
}

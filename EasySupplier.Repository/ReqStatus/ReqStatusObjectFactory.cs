using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    

    internal class ReqStatusObjectFactory : IDomainObjectFactory<ReqStatus>
    {
        public ReqStatus Construct(IDataReader reader)
        {
            ReqStatus ReqStatus = new ReqStatus();

            

            return ReqStatus;
        }
    }
}

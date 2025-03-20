using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    internal class VendorStatusObjectFactory : IDomainObjectFactory<VendorStatus>
    {
        public VendorStatus Construct(IDataReader reader)
        {
            VendorStatus VendorStatus = new VendorStatus();



            return VendorStatus;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface IPaymentBlockService
    {
        IList<SAPMaster> GetAllPaymentBlockData(SAPMaster input);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface IHouseBankService
    {
        IList<SAPMaster> GetAllHouseBankData(SAPMaster input);
    }
}

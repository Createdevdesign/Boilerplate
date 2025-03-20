using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface IWithholdingTaxTypeExemptionService
    {
        IList<SAPMaster> GetAllWithholdingTaxTypeExemptionData(SAPMaster input);
    }
}

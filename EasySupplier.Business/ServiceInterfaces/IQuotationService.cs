using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
 
    public interface IQuotationService
    {
  
        IList<Quotation> GetAllQuotationData(Quotation input);

        Quotation InsertQuotation(Quotation input);
    }
}

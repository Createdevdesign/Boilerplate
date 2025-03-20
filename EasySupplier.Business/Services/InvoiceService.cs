using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   
    internal class InvoiceService : IInvoiceService
    {
        private IDataManger InvoiceDataManger;

        public InvoiceService(DataManger dataManger)
        {
            this.InvoiceDataManger = dataManger;
        }

        public IList<Invoice> GetAllInvoiceData(Invoice input)
        {
            var InvoiceData = InvoiceDataManger.GetAllInvoiceData(input);
            return InvoiceData;
        }
    }
}

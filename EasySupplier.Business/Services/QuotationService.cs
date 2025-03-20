using BoilerSupplier.DataTransferObject;
using BoilerSupplier.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerSupplier.Business
{
   

    internal class QuotationService : IQuotationService
    {
        private IDataManger QuotationDataManger;

        public QuotationService(DataManger dataManger)
        {
            this.QuotationDataManger = dataManger;
        }

        public IList<Quotation> GetAllQuotationData(Quotation input)
        {
            var QuotationData = QuotationDataManger.GetAllQuotationData(input);
            return QuotationData;
        }

        public Quotation InsertQuotation(Quotation input)
        {
            return QuotationDataManger.InsertQuotation(input);
        }
    }
}

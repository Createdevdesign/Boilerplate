using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    

    public interface IWithholdingTaxListService
    {
        /// <summary>
        /// Get all WithholdingTaxList  data
        /// </summary>
        /// <param name="input">WithholdingTax Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<WithholdingTax> GetAllWithholdingTaxListData(WithholdingTax input);

        WithholdingTax GetWithholdingTaxListData(WithholdingTax input);
    }
}

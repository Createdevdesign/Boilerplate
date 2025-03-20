using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;
namespace BoilerSupplier.Business
{
  
    public interface IWithholdingTaxService
    {
        /// <summary>
        /// Get all WithholdingTax data
        /// </summary>
        /// <param name="input">WithholdingTax Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<WithholdingTax> GetAllWithholdingTaxData(WithholdingTax input);
    }
}

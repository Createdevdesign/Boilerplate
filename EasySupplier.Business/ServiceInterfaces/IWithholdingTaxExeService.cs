using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;


namespace BoilerSupplier.Business
{
    
    public interface IWithholdingTaxExeService
    {
        /// <summary>
        /// Get all WithholdingTaxExe data
        /// </summary>
        /// <param name="input">WithholdingTaxExe Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<WithholdingTaxExe> GetAllWithholdingTaxExeData(WithholdingTaxExe input);
    }
}

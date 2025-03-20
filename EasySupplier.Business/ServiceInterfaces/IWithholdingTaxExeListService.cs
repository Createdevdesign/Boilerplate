using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
    {
   

    public interface IWithholdingTaxExeListService
    {
        /// <summary>
        /// Get all WithholdingTaxExeList data
        /// </summary>
        /// <param name="input">WithholdingTaxExe Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<WithholdingTaxExe> GetAllWithholdingTaxExeListData(WithholdingTaxExe input);

        WithholdingTaxExe GetWithholdingTaxExeListData(WithholdingTaxExe input);
    }
}

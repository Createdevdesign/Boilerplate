using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    
    public interface IBankingDetailsService
    {
        /// <summary>
        /// Get all BankingDetail Master data
        /// </summary>
        /// <param name="input">BankingDetail Domain Object</param>
        /// <returns>Collection of Department Domain Object</returns>
        IList<BankingDetail> GetAllBankingDetailsData(BankingDetail input);
    }
}

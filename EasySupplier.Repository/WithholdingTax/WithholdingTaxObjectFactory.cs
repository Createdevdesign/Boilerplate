using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
    
    internal class WithholdingTaxObjectFactory : IDomainObjectFactory<WithholdingTax>
    {
        public WithholdingTax Construct(IDataReader reader)
        {
            WithholdingTax WithholdingTax = new WithholdingTax();

            WithholdingTax.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            WithholdingTax.Ekorg = null != reader[Constants.OUT_EKORG] ? reader[Constants.OUT_EKORG].ToString().Trim() : string.Empty;
            WithholdingTax.WITHT = null != reader[Constants.OUT_WITHT] ? reader[Constants.OUT_WITHT].ToString().Trim() : string.Empty;
            WithholdingTax.WT_WITHCD = null != reader[Constants.OUT_WT_WITHCD] ? reader[Constants.OUT_WT_WITHCD].ToString().Trim() : string.Empty;
            WithholdingTax.QSREC = null != reader[Constants.OUT_QSREC] ? reader[Constants.OUT_QSREC].ToString().Trim() : string.Empty;

           

            return WithholdingTax;
        }
    }
}

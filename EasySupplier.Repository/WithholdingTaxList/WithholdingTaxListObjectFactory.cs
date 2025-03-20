using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
   

    internal class WithholdingTaxListObjectFactory : IDomainObjectFactory<WithholdingTax>
    {
        public WithholdingTax Construct(IDataReader reader)
        {
            WithholdingTax WithholdingTaxList = new WithholdingTax();

            WithholdingTaxList.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            WithholdingTaxList.Ekorg = null != reader[Constants.OUT_EKORG] ? reader[Constants.OUT_EKORG].ToString().Trim() : string.Empty;
            WithholdingTaxList.WITHT = null != reader[Constants.OUT_WITHT] ? reader[Constants.OUT_WITHT].ToString().Trim() : string.Empty;
            WithholdingTaxList.WT_WITHCD = null != reader[Constants.OUT_WT_WITHCD] ? reader[Constants.OUT_WT_WITHCD].ToString().Trim() : string.Empty;
            WithholdingTaxList.QSREC = null != reader[Constants.OUT_QSREC] ? reader[Constants.OUT_QSREC].ToString().Trim() : string.Empty;

            WithholdingTaxList.WITHTTEXT = null != reader[Constants.OUT_WITHT_TEXT] ? reader[Constants.OUT_WITHT_TEXT].ToString().Trim() : string.Empty;
            WithholdingTaxList.WT_WITHCDTEXT = null != reader[Constants.OUT_WT_WITHCD_TEXT] ? reader[Constants.OUT_WT_WITHCD_TEXT].ToString().Trim() : string.Empty;
            WithholdingTaxList.QSRECTEXT = null != reader[Constants.OUT_QSREC_TEXT] ? reader[Constants.OUT_QSREC_TEXT].ToString().Trim() : string.Empty;

            return WithholdingTaxList;
        }
    }
}

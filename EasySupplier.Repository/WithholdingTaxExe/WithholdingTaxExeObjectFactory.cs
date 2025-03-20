using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;

namespace BoilerSupplier.Repository
{
 
    internal class WithholdingTaxExeObjectFactory : IDomainObjectFactory<WithholdingTaxExe>
    {
        public WithholdingTaxExe Construct(IDataReader reader)
        {
            WithholdingTaxExe WithholdingTaxExe = new WithholdingTaxExe();

            WithholdingTaxExe.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            WithholdingTaxExe.Ekorg = null != reader[Constants.OUT_EKORG] ? reader[Constants.OUT_EKORG].ToString().Trim() : string.Empty;
            WithholdingTaxExe.SECCODE = null != reader[Constants.OUT_SECCODE] ? reader[Constants.OUT_SECCODE].ToString().Trim() : string.Empty;
            WithholdingTaxExe.WT_EXNR = null != reader[Constants.OUT_WT_EXNR] ? reader[Constants.OUT_WT_EXNR].ToString().Trim() : string.Empty;
            WithholdingTaxExe.WT_EXRT = null != reader[Constants.OUT_WT_EXRT] ? Convert.ToDecimal(reader[Constants.OUT_WT_EXRT].ToString().Trim()) : 0;
            WithholdingTaxExe.WT_EXDF = null != reader[Constants.OUT_WT_EXDF] ? Convert.ToDateTime(reader[Constants.OUT_WT_EXDF].ToString().Trim()) : DateTime.Today;
            WithholdingTaxExe.WT_EXDT = null != reader[Constants.OUT_WT_EXDT] ? Convert.ToDateTime(reader[Constants.OUT_WT_EXDT].ToString().Trim()) : DateTime.Today;
            WithholdingTaxExe.WT_WTEXRS = null != reader[Constants.OUT_WT_WTEXRS] ? reader[Constants.OUT_WT_WTEXRS].ToString().Trim() : string.Empty;
            WithholdingTaxExe.WITHT = null != reader[Constants.OUT_WITHT] ? reader[Constants.OUT_WITHT].ToString().Trim() : string.Empty;
            WithholdingTaxExe.WT_WITHCD = null != reader[Constants.OUT_WT_WITHCD] ? reader[Constants.OUT_WT_WITHCD].ToString().Trim() : string.Empty;
            WithholdingTaxExe.FIWTIN_EXEM_THR = null != reader[Constants.OUT_FIWTIN_EXEM_THR] ? Convert.ToDecimal(reader[Constants.OUT_FIWTIN_EXEM_THR].ToString().Trim()) : 0;
            WithholdingTaxExe.WAERS = null != reader[Constants.OUT_WAERS] ? reader[Constants.OUT_WAERS].ToString().Trim() : string.Empty;

          
            return WithholdingTaxExe;
        }
    }
}


using BoilerSupplier.CrossCutting;
using BoilerSupplier.DataTransferObject;
using System;
using System.Data;


namespace BoilerSupplier.Repository
{
    

    internal class WithholdingTaxExeListObjectFactory : IDomainObjectFactory<WithholdingTaxExe>
    {
        public WithholdingTaxExe Construct(IDataReader reader)
        {
            WithholdingTaxExe WithholdingTaxExeList = new WithholdingTaxExe();

            WithholdingTaxExeList.VendorCode = null != reader[Constants.OUT_VENDOR_CODE] ? reader[Constants.OUT_VENDOR_CODE].ToString().Trim() : string.Empty;
            WithholdingTaxExeList.Ekorg = null != reader[Constants.OUT_EKORG] ? reader[Constants.OUT_EKORG].ToString().Trim() : string.Empty;
            WithholdingTaxExeList.SECCODE = null != reader[Constants.OUT_SECCODE] ? reader[Constants.OUT_SECCODE].ToString().Trim() : string.Empty;
            WithholdingTaxExeList.WT_EXNR = null != reader[Constants.OUT_WT_EXNR] ? reader[Constants.OUT_WT_EXNR].ToString().Trim() : string.Empty;
            WithholdingTaxExeList.WT_EXRT = null != reader[Constants.OUT_WT_EXRT] ? Convert.ToDecimal(reader[Constants.OUT_WT_EXRT].ToString().Trim()) : 0;
            WithholdingTaxExeList.WT_EXDF = null != reader[Constants.OUT_WT_EXDF] ? Convert.ToDateTime(reader[Constants.OUT_WT_EXDF].ToString().Trim()) : DateTime.Today;
            WithholdingTaxExeList.WT_EXDT = null != reader[Constants.OUT_WT_EXDT] ? Convert.ToDateTime(reader[Constants.OUT_WT_EXDT].ToString().Trim()) : DateTime.Today;
            WithholdingTaxExeList.WT_WTEXRS = null != reader[Constants.OUT_WT_WTEXRS] ? reader[Constants.OUT_WT_WTEXRS].ToString().Trim() : string.Empty;
            WithholdingTaxExeList.WITHT = null != reader[Constants.OUT_WITHT] ? reader[Constants.OUT_WITHT].ToString().Trim() : string.Empty;
            WithholdingTaxExeList.WT_WITHCD = null != reader[Constants.OUT_WT_WITHCD] ? reader[Constants.OUT_WT_WITHCD].ToString().Trim() : string.Empty;
            WithholdingTaxExeList.FIWTIN_EXEM_THR = null != reader[Constants.OUT_FIWTIN_EXEM_THR] ? Convert.ToDecimal(reader[Constants.OUT_FIWTIN_EXEM_THR].ToString().Trim()) : 0;
            WithholdingTaxExeList.WAERS = null != reader[Constants.OUT_WAERS] ? reader[Constants.OUT_WAERS].ToString().Trim() : string.Empty;

            WithholdingTaxExeList.SECCODETEXT = null != reader[Constants.OUT_SECCODE_TEXT] ? reader[Constants.OUT_SECCODE_TEXT].ToString().Trim() : string.Empty;
            WithholdingTaxExeList.WITHTTEXT = null != reader[Constants.OUT_WITHT_TEXT] ? reader[Constants.OUT_WITHT_TEXT].ToString().Trim() : string.Empty;
            WithholdingTaxExeList.WT_WITHCDTEXT = null != reader[Constants.OUT_WT_WITHCD_TEXT] ? reader[Constants.OUT_WT_WITHCD_TEXT].ToString().Trim() : string.Empty;
            WithholdingTaxExeList.WAERSTEXT = null != reader[Constants.OUT_WAERS_TEXT] ? reader[Constants.OUT_WAERS_TEXT].ToString().Trim() : string.Empty;


            return WithholdingTaxExeList;
        }
    }
}
